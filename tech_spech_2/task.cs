using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tech_spech_2
{
    public partial class task : Form
    {
        public task()
        {
            InitializeComponent();
        }

        private void task_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet11.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.tech_specDataSet11.DataTable2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.tech_specDataSet1.task);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_task new_Task_form = new new_task();
            new_Task_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search search_form = new search();
            search_form.Show();
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


