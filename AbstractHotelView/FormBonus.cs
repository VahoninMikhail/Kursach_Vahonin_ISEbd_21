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
    public partial class FormBonus : Form
    {
        public int Id { set { id = value; } }

        private int? id;

        public FormBonus()
        {
            InitializeComponent();
        }

        private void FormAddBonuses_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var posetitel = Task.Run(() => ApiClient.GetRequestData<PosetitelViewModel>("api/Posetitel/Get/" + id.Value)).Result;
                    textBoxFIO.Text = posetitel.PosetitelFIO;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSum.Text))
            {
                MessageBox.Show("Заполните поле Количество бонусов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int sum = 0;
            try
            {
                sum = Convert.ToInt32(textBoxSum.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Task task = Task.Run(() => ApiClient.PutRequestData("api/Posetitel/RaiseBonuses", new RepaymentBindingModel
            {
                PosetitelId = id.Value,
                Calculation = sum
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
