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

        public List<Phim> sqlPhimxemnhieu()
        {
            List<Phim> list = new List<Phim>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from PHIM order by luotxem DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Phim()
                    {
                        idphim = Convert.ToInt32(reader["idphim"]),
                        tenphimtv = reader["tenphimtv"].ToString(),
                        hinhanh = reader["hinhanh"].ToString()
                    });
                }
                reader.Close();
            }
            conn.Close();
            return list;
        }

        public List<Phim> sqlPhimyeuthich()
        {
            List<Phim> list = new List<Phim>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from PHIM order by yeuthich DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Phim()
                    {
                        idphim = Convert.ToInt32(reader["idphim"]),
                        tenphimtv = reader["tenphimtv"].ToString(),
                        hinhanh = reader["hinhanh"].ToString()
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
                while (reader.Read())
                {
                    p.idphim = Convert.ToInt32(id);
                    p.tenphimtv = reader["tenphimtv"].ToString();
                    p.tenphimta = reader["tenphimta"].ToString();
                    p.danhmuc = reader["danhmuc"].ToString();
                    p.daodien = reader["daodien"].ToString();
                    p.dienvien = reader["dienvien"].ToString();
                    p.linkphim = reader["linkphim"].ToString();
                    p.luotxem = Convert.ToInt32(reader["luotxem"]);
                    p.yeuthich = Convert.ToInt32(reader["yeuthich"]);
                    p.luotdanhgia = Convert.ToInt32(reader["luotdanhgia"]);
                    p.sao = float.Parse(reader["sao"].ToString());
                    p.phathanh = Convert.ToInt32(reader["phathanh"]);
                    p.theloai = reader["theloai"].ToString();
                    p.thoiluong = reader["thoiluong"].ToString();
                    p.mota = reader["mota"].ToString();
                    p.hinhanh = reader["hinhanh"].ToString();
                }                
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
        public void tangluotthich(int id, int luotthich)
        {
            luotthich += 1;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "update Phim set yeuthich=@sl where idphim=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("sl", luotthich);
            var tmp = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void tangluotdanhgia(int id, int danhgia)
        {
            danhgia += 1;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "update Phim set yeuthich=@sl where idphim=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("sl", danhgia);
            var tmp = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void danhgiasao(int id, float sao, int luotdanhgia, int sosao)
        {            
            var danhgia = (sao * luotdanhgia + sosao) / (luotdanhgia + 1);
            luotdanhgia += 1;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "update Phim set luotdanhgia=@sl where idphim=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("sl", luotdanhgia);
            var tmp = cmd.ExecuteNonQuery();
            //
            //var danhgia = (sao * luotdanhgia + sosao) / (luotdanhgia + 1);
            string query1 = "update Phim set sao=@sl where idphim=@id";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("id", id);
            cmd1.Parameters.AddWithValue("sl", danhgia);
            var tmp1 = cmd1.ExecuteNonQuery();
            conn.Close();
        }

        public void themyeuthich(int id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            int id_tmp = 0;
            string query = "select * from YeuThich where idphim = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id_tmp = Convert.ToInt32(reader["idphim"]);
                }
            }
            if (id_tmp != 0)
            {
                string query1 = "delete from YeuThich where idphim=@id";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("id", id);
                var tmp1 = cmd1.ExecuteNonQuery();
            }
            string query2 = "insert into YeuThich values (@id)";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("id", id);
            var tmp2 = cmd2.ExecuteNonQuery();
            conn.Close();
        }

        public void themdaxem(int id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            int id_tmp = 0;
            string query = "select * from Daxem where idphim = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id_tmp = Convert.ToInt32(reader["idphim"]);
                }               
            }
            if (id_tmp != 0)
            {
                string query1 = "delete from Daxem where idphim=@id";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.Parameters.AddWithValue("id", id);
                var tmp1 = cmd1.ExecuteNonQuery();
            }
            string query2 = "insert into Daxem values (@id,0)";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("id", id);
            var tmp2 = cmd2.ExecuteNonQuery();
            conn.Close();
        }

        public List<int> Phimyeuthich()
        {
            List<int> list = new List<int>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from YeuThich order by idyeuthich DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(Convert.ToInt32(reader["idphim"]));
                }
                reader.Close();
            }
            conn.Close();
            return list;
        }
        public List<int> Phimdaxem()
        {
            List<int> list = new List<int>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "select * from Daxem order by iddaxem DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(Convert.ToInt32(reader["idphim"]));
                }
                reader.Close();
            }
            conn.Close();
            return list;
        }

        public List<Phim> listPhimyeuthich()
        {
            List<Phim> list = new List<Phim>();
            List<int> l = new List<int>();
            l = Phimyeuthich();
            for (int i = 0; i < l.Count(); i++)
            {
                Phim p = sqlPhim(l[i].ToString());
                list.Add(p);
            }
            return list;
        }

        public List<Phim> listPhimdaxem()
        {
            List<Phim> list = new List<Phim>();
            List<int> l = new List<int>();
            l = Phimdaxem();
            for (int i = 0; i < l.Count(); i++)
            {
                Phim p = sqlPhim(l[i].ToString());
                list.Add(p);
            }
            return list;
        }

        public List<Phim> timkiem( string khoa)
        {
            List<Phim> list = new List<Phim>();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            string query = @"select * from PHIM where tenphimtv LIKE '%" + khoa + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Phim()
                    {
                        idphim = Convert.ToInt32(reader["idphim"]),
                        tenphimtv = reader["tenphimtv"].ToString(),
                        hinhanh = reader["hinhanh"].ToString()
                    });
                }
                reader.Close();
            }
            conn.Close();
            return list;
        }
    }
}
