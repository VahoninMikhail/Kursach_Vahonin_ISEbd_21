using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormAddUsluga : Form
    {
        public UslugaZakazViewModel Model { get; set; }

        public FormAddUsluga()
        {
            InitializeComponent();
        }

        private void FormAddUsluga_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxUsluga.DisplayMember = "UslugaName";
                comboBoxUsluga.ValueMember = "Id";
                comboBoxUsluga.DataSource = Task.Run(() => ApiClient.GetRequestData<List<UslugaViewModel>>("api/Usluga/GetList")).Result;
                comboBoxUsluga.SelectedItem = null;
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Model != null)
            {
                comboBoxUsluga.Enabled = false;
                comboBoxUsluga.SelectedValue = Model.UslugaId;
                textBoxCount.Text = Model.Count.ToString();
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxUsluga.SelectedValue == null)
            {
                MessageBox.Show("Выберите услугу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (Model == null)
                {
                    Model = new UslugaZakazViewModel
                    {
                        UslugaId = Convert.ToInt32(comboBoxUsluga.SelectedValue),
                        UslugaName = comboBoxUsluga.Text,
                        Count = Convert.ToInt32(textBoxCount.Text)
                    };
                }
                else
                {
                    Model.Count = Convert.ToInt32(textBoxCount.Text);
                }
                var model = await Task.Run(() => ApiClient.GetRequestData<UslugaViewModel>("api/Usluga/Get/" + Model.UslugaId));
                Model.Price = model.Price;
                Model.Total = Model.Price * Model.Count;
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

