using System;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните поле логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните поле пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ApiClient.Login(textBoxLogin.Text, textBoxPassword.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Clear();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            var form = new FormInitAdministrator();
            form.ShowDialog();
        }
    }
}

