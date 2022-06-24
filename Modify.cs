using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand SqlCommand; //dung de truy van cac cau lenh insert,update,delete,...
        SqlDataReader dataReader; // dung de doc du lieu trong bang


        public List<Taikhoan> TaiKhoans(string query) //check tai khoan
        {
            List<Taikhoan> taikhoans = new List<Taikhoan>();
            using (SqlConnection sqlConnection = connection.GetSqlConnection() )
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = SqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taikhoans.Add(new Taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }

            return taikhoans;
        }
        public void Command(string query) //dung de dang ky tai khoan
        {
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.ExecuteNonQuery(); //thuc thi cau truy van
                sqlConnection.Close();
            }
        }
    }
}
