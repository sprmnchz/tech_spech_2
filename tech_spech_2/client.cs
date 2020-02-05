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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SqlCommand command = new SqlCommand("INSERT INTO organization (name, adress) VALUES (@name,@adress)", db.getConnection());
            
            command.Parameters.Add("@name", SqlDbType.VarChar).Value=textBox5.Text;
            command.Parameters.Add("@adress", SqlDbType.VarChar).Value = textBox6.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("+");
            else
                MessageBox.Show("-");

            db.closeConnection();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            SqlCommand command = new SqlCommand("INSERT INTO client (first_name, second_name, patronumic, organization_id,telephone) VALUES (@first_name, @second_name, @patronumic,(SELECT organization_id FROM organization WHERE name = @organization_name),@telephone)", db.getConnection());
            
            command.Parameters.Add("@first_name", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@second_name", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@patronumic", SqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@organization_name", SqlDbType.VarChar).Value = textBox7.Text;
            command.Parameters.Add("@telephone", SqlDbType.VarChar).Value = textBox4.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("+");
            else
                MessageBox.Show("-");

            db.closeConnection();
        }
    }
}
