using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormZakaz : Form
    {
        private List<UslugaZakazViewModel> uslugaZakazs;

        public FormZakaz()
        {
            InitializeComponent();
        }

        private void FormZakaz_Load(object sender, EventArgs e)
        {
            try
            {
                List<PosetitelViewModel> list = Task.Run(() => ApiClient.GetRequestData<List<PosetitelViewModel>>("api/Posetitel/GetList")).Result;
                if (list != null)
                {
                    comboBoxPosetitel.DisplayMember = "PosetitelFIO";
                    comboBoxPosetitel.ValueMember = "Id";
                    comboBoxPosetitel.DataSource = list;
                    comboBoxPosetitel.SelectedItem = null;
                }
                dateTimePickerCredit.Value = DateTime.Now.AddMonths(3);
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            uslugaZakazs = new List<UslugaZakazViewModel>();
        }

        private void LoadData()
        {
            try
            {
                if (uslugaZakazs != null)
                {
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = uslugaZakazs;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;
                    dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormAddUsluga();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.Model != null)
                {
                    uslugaZakazs.Add(form.Model);
                }
                textBoxSum.Text = uslugaZakazs.Select(rec => rec.Total).DefaultIfEmpty(0).Sum().ToString();
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = new FormAddUsluga();
                form.Model = uslugaZakazs[dataGridView.SelectedRows[0].Cells[0].RowIndex];
                if (form.ShowDialog() == DialogResult.OK)
                {
                    uslugaZakazs[dataGridView.SelectedRows[0].Cells[0].RowIndex] = form.Model;
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        uslugaZakazs.RemoveAt(dataGridView.SelectedRows[0].Cells[0].RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxPosetitel.SelectedValue == null)
            {
                MessageBox.Show("Выберите посетителя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (uslugaZakazs == null || uslugaZakazs.Count == 0)
            {
                MessageBox.Show("Заполните услуги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePickerCredit.Value < DateTime.Now)
            {
                MessageBox.Show("Ошибка в дате окончания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxOplata.Text))
            {
                MessageBox.Show("Введите сумму оплаты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<UslugaZakazBindingModel> uslugaZakazBM = new List<UslugaZakazBindingModel>();
            foreach (var uslugaZakaz in uslugaZakazs)
            {
                uslugaZakazBM.Add(new UslugaZakazBindingModel
                {
                    UslugaId = uslugaZakaz.UslugaId,
                    Count = uslugaZakaz.Count
                });
            }

            int pay;
            try
            {
                pay = Convert.ToInt32(textBoxOplata.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int posetitelId = Convert.ToInt32(comboBoxPosetitel.SelectedValue);
            Task task = Task.Run(() => ApiClient.PostRequestData("api/Zakaz/AddElement", new ZakazBindingModel
            {
                PosetitelId = posetitelId,
                PogashenieEnd = dateTimePickerCredit.Value,
                UslugaZakazs = uslugaZakazBM,
                Payed = pay
            }));


            task.ContinueWith((prevTask) => MessageBox.Show("Сохранение прошло успешно. Обновите список", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information),
                TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith((prevTask) =>
            {
                var ex = (Exception)prevTask.Exception;
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }, TaskContinuationOptions.OnlyOnFaulted);

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

