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
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task task_Form = new task();
            task_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cartridge cartridge_form = new cartridge();
            cartridge_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new_data new_data_form = new new_data();
            new_data_form.Show();
        }
    }
}
