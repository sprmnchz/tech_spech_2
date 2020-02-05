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
    public partial class new_task : Form
    {
        public new_task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client client_form = new client();
            client_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new_data new_Data_form = new new_data();
            new_Data_form.Show();
        }

        private void New_task_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.tech_specDataSet1.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.equipment_manufacturer". При необходимости она может быть перемещена или удалена.
            this.equipment_manufacturerTableAdapter.Fill(this.tech_specDataSet1.equipment_manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.equipment_model". При необходимости она может быть перемещена или удалена.
            this.equipment_modelTableAdapter.Fill(this.tech_specDataSet1.equipment_model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tech_specDataSet1.tech_spec". При необходимости она может быть перемещена или удалена.
            this.tech_specTableAdapter.Fill(this.tech_specDataSet1.tech_spec);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SqlCommand command = new SqlCommand("INSERT INTO equipment (manufacturer_id,model_id,serial_number,defect,piking) VALUES (@manufacturer_id,@model_id,@serial_number,@defect,@piking)", db.getConnection());

            command.Parameters.Add("@manufacturer_id", SqlDbType.Int).Value = comboBox2.SelectedIndex+1;
            command.Parameters.Add("@model_id", SqlDbType.Int).Value = comboBox3.SelectedIndex+1;
            command.Parameters.Add("@serial_number", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@defect", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@piking", SqlDbType.VarChar).Value = textBox3.Text;

            SqlCommand command2 = new SqlCommand("INSERT INTO task (client_id,data,euipment_id,owner_id) VALUES (@client_id,(SELECT CAST(GETDATE() AS DATE)),(SELECT MAX(equipment_id) FROM equipment),@tech_spec_id)", db.getConnection());

            command2.Parameters.Add("@client_id", SqlDbType.Int).Value = comboBox1.SelectedIndex+1;
            command2.Parameters.Add("@tech_spec_id", SqlDbType.Int).Value = comboBox4.SelectedIndex+1;

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
