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
    public partial class new_data : Form
    {
        public new_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                if (checkBox1.Checked == true)
                {
                    DB db = new DB();

                    SqlCommand command = new SqlCommand("INSERT INTO equipment_manufacturer (name) VALUES (@name)", db.getConnection());

                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox1.Text;
                    
                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("+");
                    else
                        MessageBox.Show("-");

                    db.closeConnection();
                }
                if (checkBox2.Checked == true)
                    
                    {
                        DB db = new DB();

                        SqlCommand command = new SqlCommand("INSERT INTO equipment_model (name) VALUES (@name)", db.getConnection());

                        command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox2.Text;

                        db.openConnection();

                        if (command.ExecuteNonQuery() == 1)
                            MessageBox.Show("+");
                        else
                            MessageBox.Show("-");

                        db.closeConnection();
                    }

            }
            if (radioButton1.Checked==true)
            {
                if (checkBox1.Checked == true)
                {
                    DB db = new DB();

                    SqlCommand command = new SqlCommand("INSERT INTO cartridge_manufacturer (name) VALUES (@name)", db.getConnection());

                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox1.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("+");
                    else
                        MessageBox.Show("-");

                    db.closeConnection();
                }
                if (checkBox2.Checked == true)

                {
                    DB db = new DB();

                    SqlCommand command = new SqlCommand("INSERT INTO cartridge_model (name) VALUES (@name)", db.getConnection());

                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox2.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("+");
                    else
                        MessageBox.Show("-");

                    db.closeConnection();
                }
            }
        }
    }
}
