using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;




namespace UserText.DatabaseQy
{
    public class DatabaseQuery
    {
        public string Select(string sqlParameter, string connString)
        {
            StringBuilder stringBuilder = new StringBuilder();  
            SqlDataAdapter sqlSelect = new SqlDataAdapter(sqlParameter, connString);
            DataTable dt = new DataTable();
            sqlSelect.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["TEXT"]);
                stringBuilder.Append(dr["TEXT"] + Environment.NewLine);
            }
            return stringBuilder.ToString();
        }

        public void Insert(string userText, string connString)
        {
            var con = new SqlConnection(connString);
            string sqlQuery = "INSERT INTO UserText VALUES (@value);";
            var cmd = new SqlCommand(sqlQuery, con);

            con.Open();
            cmd.Parameters.AddWithValue("@value", userText);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}




