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
                p.danhmuc = reader["danhmuc"].ToString();
                p.daodien = reader["daodien"].ToString();
                p.dienvien = reader["dienvien"].ToString();
                p.linkphim = reader["linkphim"].ToString();
                p.luotxem = Convert.ToInt32(reader["luotxem"]);
                p.yeuthich = Convert.ToInt32(reader["yeuthich"]);
                p.sao = Convert.ToInt32(reader["sao"]);
                p.phathanh = Convert.ToInt32(reader["phathanh"]);
                p.theloai = reader["theloai"].ToString();
                p.thoiluong = reader["thoiluong"].ToString();
                p.mota = reader["mota"].ToString();
                p.hinhanh = reader["hinhanh"].ToString();
                reader.Close();
            }                           
            conn.Close();
            return p;
        }
        public void tangluotxem(int id, int luotxem)
        {
            luotxem += 1;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "update Phim set luotxem=@sl where idphim=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("sl", luotxem);
            var tmp = cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
