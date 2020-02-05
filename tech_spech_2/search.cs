using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tech_spech_2
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
               



       
           
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this.tech_specDataSet1.DataTable2);

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            dataTable2BindingSource.Filter = " [Фамилия Клиента] LIKE'" + textBox1.Text + "%'";

        }
    }
}
