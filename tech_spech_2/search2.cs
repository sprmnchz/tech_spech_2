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
    public partial class search2 : Form
    {
        public search2()
        {
            InitializeComponent();
        }

        private void Search2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.tech_specDataSet1.DataTable1);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataTable1BindingSource.Filter = " [Фамилия Клиента] LIKE'" + textBox1.Text + "%'";
        }
    }
}
