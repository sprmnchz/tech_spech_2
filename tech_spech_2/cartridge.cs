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
    public partial class cartridge : Form
    {
        public cartridge()
        {
            InitializeComponent();
        }

        private void cartridge_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet12.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.tech_specDataSet12.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet11.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.tech_specDataSet11.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.cartridge". При необходимости она может быть перемещена или удалена.
            this.cartridgeTableAdapter1.Fill(this.tech_specDataSet1.cartridge);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet.cartridge". При необходимости она может быть перемещена или удалена.
            this.cartridgeTableAdapter.Fill(this.tech_specDataSet.cartridge);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search2 search2_form = new search2();
            search2_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_cartridge new_Cartridge_form = new new_cartridge();
            new_Cartridge_form.Show();
        }
    }
}
