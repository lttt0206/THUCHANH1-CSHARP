using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;

namespace AppPhim
{
    public partial class TVShow: KryptonForm
    {
        public TVShow()
        {
            InitializeComponent();
            Xuly_Data s = new Xuly_Data();
            List<Phim> list = s.sqlGetPhim("TVShow");
            int i = 0;

            if (list.Count > i)
            {
                pictureBox1.ImageLocation = list[i].hinhanh;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label1.Text = list[i].tenphimtv;
                i++;
                label_trong.Hide();
            }
            else
            {
                label1.Text = "";
                label_trong.Text = "Chưa có dữ liệu phim";
            }

            if (list.Count > i)
            {
                pictureBox2.ImageLocation = list[i].hinhanh;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                label2.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label2.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox3.ImageLocation = list[i].hinhanh;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                label3.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label3.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox4.ImageLocation = list[i].hinhanh;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                label4.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label4.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox5.ImageLocation = list[i].hinhanh;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                label5.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label5.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox6.ImageLocation = list[i].hinhanh;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                label6.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label6.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox7.ImageLocation = list[i].hinhanh;
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                label7.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label7.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox8.ImageLocation = list[i].hinhanh;
                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                label8.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label8.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox9.ImageLocation = list[i].hinhanh;
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                label9.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label9.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox10.ImageLocation = list[i].hinhanh;
                pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                label10.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label10.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox11.ImageLocation = list[i].hinhanh;
                pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                label11.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label11.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox12.ImageLocation = list[i].hinhanh;
                pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                label12.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label12.Text = "";
            }
        }

        private void Anime_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[0].idphim.ToString();
                ct.Show();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!label2.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[1].idphim.ToString();
                ct.Show();
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!label3.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[2].idphim.ToString();
                ct.Show();
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (!label4.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[3].idphim.ToString();
                ct.Show();
            }
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            if (!label12.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[11].idphim.ToString();
                ct.Show();
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!label5.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[4].idphim.ToString();
                ct.Show();
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!label6.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[5].idphim.ToString();
                ct.Show();
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (!label7.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[6].idphim.ToString();
                ct.Show();
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (!label8.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[7].idphim.ToString();
                ct.Show();
            }
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (!label9.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[9].idphim.ToString();
                ct.Show();
            }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (!label10.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[9].idphim.ToString();
                ct.Show();
            }
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            if (!label11.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlGetPhim("TVShow");
                CTPhim ct = new CTPhim();
                ct.Message = list[10].idphim.ToString();
                ct.Show();
            }
        }
    }
}
