using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppPhim
{
    class Xuly_Data
    {
        public List<Phim> sqlGetPhim(string tukhoa)
        {
            List<Phim> list = new List<Phim>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from PHIM where danhmuc = '" + tukhoa + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Phim()
                    {
                        idphim = Convert.ToInt32(reader["idphim"]),
                        tenphimtv = reader["tenphimtv"].ToString(),
                        hinhanh =reader["hinhanh"].ToString()
                    });
                }
                reader.Close();
            }
            conn.Close();
            return list;
        }

        public Phim sqlPhim(string id)
        {
            Phim p = new Phim();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from PHIM where idphim = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                reader.Read();
                p.idphim = Convert.ToInt32(id);
                p.tenphimtv = reader["tenphimtv"].ToString();
                p.tenphimta = reader["tenphimta"].ToString();
                p.hinhanh = reader["hinhanh"].ToString();
                reader.Close();
            }                           
            conn.Close();
            return p;
        }

    }
}
