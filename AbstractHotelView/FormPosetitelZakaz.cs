using AbstracHotelService.BindingModels;
using AbstracHotelService.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractHotelView
{
    public partial class FormPosetitelZakaz : Form
    {
        public int Id { set { id = value; } }

        private int? id;

        public FormPosetitelZakaz()
        {
            InitializeComponent();
        }

        private void FormPosetitelZakaz_Load(object sender, EventArgs e)
        {
            try
            {
                List<ZakazViewModel> list =
                    Task.Run(() => ApiClient.GetRequestData<List<ZakazViewModel>>("api/Zakaz/GetPosetitelList/" + id.Value)).Result;
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;
                    dataGridView.Columns[10].Visible = false;
                    dataGridView.AutoResizeColumns();
                    dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (!checkBoxDoc.Checked && !checkBoxXls.Checked)
            {
                MessageBox.Show("Выберите формат документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            Task task = Task.Run(() => ApiClient.PostRequestData("api/Report/" + ((checkBoxDoc.Checked) ? "SendPosetitelAccountDoc" : "SendPosetitelAccountXls"), new ReportBindingModel
            {
                ZakazId = id
            }));

            task.ContinueWith((prevTask) => MessageBox.Show("Сообщение отправлено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information),
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
    }
}

