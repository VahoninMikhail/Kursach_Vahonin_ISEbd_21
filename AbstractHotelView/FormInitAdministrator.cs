﻿using AbstracHotelService.BindingModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormInitAdministrator : Form
    {
        public FormInitAdministrator()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните Логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxConfimPassword.Text))
            {
                MessageBox.Show("Заполните поле Подтверждение пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string fio = textBoxFIO.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfimPassword.Text;

            Task task = Task.Run(() => ApiClient.PostRequestData("api/Account/Register", new AdministratorCreateBindingModel
            {
                AdministratorFIO = fio,
                UserName = login,
                PasswordHash = password,
                ConfirmPassword = confirmPassword
            }));


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

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
