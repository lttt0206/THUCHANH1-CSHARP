﻿using System;
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
    public partial class Anime : KryptonForm
    {
        public Anime()
        {
            InitializeComponent();
            Xuly_Data s = new Xuly_Data();
            List<Phim> list = s.sqlGetPhim("Anime");
            int i = 0;

            if (list.Count > i + 1)
            {
                pictureBox1.ImageLocation = list[i].hinhanh;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label1.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label1.Text = "";
            }

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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

            if (list.Count > i + 1)
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
            Xuly_Data s = new Xuly_Data();
            List<Phim> list = s.sqlGetPhim("Anime");
            CTPhim ct = new CTPhim();
            ct.Message = list[0].idphim.ToString();
            ct.Show();
        }
    }
}