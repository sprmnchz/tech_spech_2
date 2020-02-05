using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_spech_2
{
    class DB
    {
        
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-17F8KDD\\SQLEXPRESS;Initial Catalog=tech_spec;Integrated Security=True");
        
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
