using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormAdministrator : Form
    {
        public int Id { set { id = value; } }

        private int? id;

        public FormAdministrator()
        {
            InitializeComponent();
        }

        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var employee = Task.Run(() => ApiClient.GetRequestData<AdministratorViewModel>("api/Administrator/Get/" + id.Value)).Result;
                    textBoxFIO.Text = employee.AdministratorFIO;
                    textBoxLogin.Text = employee.UserName;
                    textBoxPassword.ReadOnly = true;
                    textBoxConfirmPassword.ReadOnly = true;
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
            else
            {
                textBoxPassword.ReadOnly = false;
                textBoxConfirmPassword.ReadOnly = false;
            }
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
                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string fio = textBoxFIO.Text;
            string login = textBoxLogin.Text;
            Task task;
            if (id.HasValue)
            {
                task = Task.Run(() => ApiClient.PutRequestData("api/Administrator/UpdElement", new AdministratorBindingModel
                {
                    Id = id.Value,
                    AdministratorFIO = fio,
                    UserName = login
                }));
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(textBoxConfirmPassword.Text))
                {
                    MessageBox.Show("Заполните поле Подтверждение пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!textBoxConfirmPassword.Text.Equals(textBoxPassword.Text))
                {
                    MessageBox.Show("Пароли должны совпадать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string password = textBoxPassword.Text;
                string confirmPassword = textBoxConfirmPassword.Text;
                task = Task.Run(() => ApiClient.PostRequestData("api/Administrator/AddElement", new AdministratorCreateBindingModel
                {
                    AdministratorFIO = fio,
                    UserName = login,
                    PasswordHash = password,
                    ConfirmPassword = confirmPassword
                }));
            }
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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

