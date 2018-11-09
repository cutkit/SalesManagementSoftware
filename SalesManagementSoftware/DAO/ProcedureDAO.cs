using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSoftware.DAO
{
    class ProcedureDAO
    {
        string strCon = @"Data Source=tungld;Initial Catalog=sales_software;Integrated Security=True";
        private static ProcedureDAO instance;

        internal static ProcedureDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProcedureDAO();
                }
                return instance;
            }
            set => instance = value;
        }
        private ProcedureDAO()
        {

        }

        public DataTable ExcuteQuery(string query, object[] param = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                if (param != null)
                {
                    string[] par = query.Split(' ');
                    int i = 0;
                    foreach (var item in par)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        //====
        public int ExcuteNoneQuery(string query, object[] param = null)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                if (param != null)
                {
                    string[] par = query.Split(' ');
                    int i = 0;
                    foreach (var item in par)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }
        //====
        public Object ExcuteScalar(string query, object[] param = null)
        {
            Object data = 0;
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                if (param != null)
                {
                    string[] par = query.Split(' ');
                    int i = 0;
                    foreach (var item in par)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                con.Close();
            }

            return data;
        }
    }
}
