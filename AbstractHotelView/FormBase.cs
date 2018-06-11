using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            var form = new FormLogin();
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
            {
                Close();
            }
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<UslugaViewModel> list =
                    Task.Run(() => ApiClient.GetRequestData<List<UslugaViewModel>>("api/Usluga/GetList")).Result;
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormUsluga();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = new FormUsluga();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
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
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);

                    Task task = Task.Run(() => ApiClient.DelRequest("api/Usluga/DelElement/" + id));
                    task.ContinueWith((prevTask) => MessageBox.Show("Запись удалена. Обновите список", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information),
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
                }

                LoadData();
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void админыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAdministrators();
            form.ShowDialog();
        }

        private void посетителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPosetitels();
            form.ShowDialog();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormZakazs();
            form.ShowDialog();
        }

        private void заблокироватьПосетителейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() => ApiClient.PostRequestData<object>("api/Posetitel/PenetrateClients", null));
            task.ContinueWith((prevTask) => MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information),
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
        }

        private void отчетПоОплатамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormOplats();
            form.ShowDialog();
        }
    }
}
