using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormUsluga : Form
    {
        public int Id { set { id = value; } }

        private int? id;

        public FormUsluga()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните Название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните Цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int price = 0;
            try
            {
                price = Convert.ToInt32(textBoxPrice.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = textBoxName.Text;
            Task task;
            if (id.HasValue)
            {
                task = Task.Run(() => ApiClient.PutRequestData("api/Usluga/UpdElement", new UslugaBindingModel
                {
                    Id = id.Value,
                    UslugaName = name,
                    Price = price
                }));
            }
            else
            {
                task = Task.Run(() => ApiClient.PostRequestData("api/Usluga/AddElement", new UslugaBindingModel
                {
                    UslugaName = name,
                    Price = price
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

        private void FormUsluga_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var service = Task.Run(() => ApiClient.GetRequestData<UslugaViewModel>("api/Usluga/Get/" + id.Value)).Result;
                    textBoxName.Text = service.UslugaName;
                    textBoxPrice.Text = service.Price.ToString();
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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

