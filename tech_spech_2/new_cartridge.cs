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
    public partial class new_cartridge : Form
    {
        public new_cartridge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client client_form = new client();
            client_form.Show();
        }

        private void new_cartridge_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.cartridge_manufacturer". При необходимости она может быть перемещена или удалена.
            this.cartridge_manufacturerTableAdapter.Fill(this.tech_specDataSet1.cartridge_manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.cartridge_model". При необходимости она может быть перемещена или удалена.
            this.cartridge_modelTableAdapter.Fill(this.tech_specDataSet1.cartridge_model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.tech_spec". При необходимости она может быть перемещена или удалена.
            this.tech_specTableAdapter.Fill(this.tech_specDataSet1.tech_spec);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.tech_specDataSet1.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.tech_specDataSet1.client);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new_data new_Data_form = new new_data();
            new_Data_form.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SqlCommand command = new SqlCommand("INSERT INTO cartridge_work (date,foto_roll,magnetic_roll,chardger,racel,dosing_blade) VALUES ((SELECT CAST(GETDATE() AS DATE)),@foto,@magnetic,@chardger,@racel,@dosing_blade)", db.getConnection());

            command.Parameters.Add("@foto", SqlDbType.Bit).Value = checkBox1.Checked;
            command.Parameters.Add("@magnetic", SqlDbType.Bit).Value = checkBox2.Checked;
            command.Parameters.Add("@chardger", SqlDbType.Bit).Value = checkBox3.Checked;
            command.Parameters.Add("@racel", SqlDbType.Bit).Value = checkBox4.Checked;
            command.Parameters.Add("@dosing_blade", SqlDbType.Bit).Value = checkBox5.Checked;

            SqlCommand command2 = new SqlCommand("INSERT INTO cartridge (manufacture_id,model_id,work_id,client_id,owner_id) VALUES (@manufacture_id,@model_id,(SELECT MAX(cartridge_work_id) FROM cartridge_work),@client_id,@tech_spec_id)", db.getConnection());

            command2.Parameters.Add("@manufacture_id", SqlDbType.Int).Value = comboBox1.SelectedIndex + 1;
            command2.Parameters.Add("@model_id", SqlDbType.Int).Value = comboBox2.SelectedIndex + 1;
            
            command2.Parameters.Add("@client_id", SqlDbType.Int).Value = comboBox3.SelectedIndex + 1;
            command2.Parameters.Add("@tech_spec_id", SqlDbType.Int).Value = comboBox4.SelectedIndex + 1;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("+");
            else
                MessageBox.Show("-");

            db.closeConnection();
            db.openConnection();

            if (command2.ExecuteNonQuery() == 1)
                MessageBox.Show("+");
            else
                MessageBox.Show("-");

            db.closeConnection();



        }
    }
}
