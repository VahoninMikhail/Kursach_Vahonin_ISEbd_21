using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormPosetitel : Form
    {
        public int Id { set { id = value; } }

        private int? id;


        public FormPosetitel()
        {
            InitializeComponent();
        }

        private void FormPosetitel_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var posetitel = Task.Run(() => ApiClient.GetRequestData<PosetitelViewModel>("api/Posetitel/Get/" + id.Value)).Result;
                    textBoxFIO.Text = posetitel.PosetitelFIO;
                    textBoxLogin.Text = posetitel.UserName;
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
            if (!string.IsNullOrEmpty(login))
            {
                if (!Regex.IsMatch(login, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"))
                {
                    MessageBox.Show("Неверный формат для электронной почты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Task task;
            if (id.HasValue)
            {
                task = Task.Run(() => ApiClient.PutRequestData("api/Posetitel/UpdElement", new PosetitelBindingModel
                {
                    Id = id.Value,
                    PosetitelFIO = fio,
                    UserName = login
                }));
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    MessageBox.Show("Заполните Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(textBoxConfirmPassword.Text))
                {
                    MessageBox.Show("Заполните Подтверждение пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!textBoxConfirmPassword.Text.Equals(textBoxPassword.Text))
                {
                    MessageBox.Show("Пароли должны совпадать", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string password = textBoxPassword.Text;
                string confirmPassword = textBoxConfirmPassword.Text;
                task = Task.Run(() => ApiClient.PostRequestData("api/Posetitel/AddElement", new PosetitelCreateBindingModel
                {
                    PosetitelFIO = fio,
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

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

