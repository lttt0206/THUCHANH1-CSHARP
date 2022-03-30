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
    public partial class CTPhim: KryptonForm
    {
        string strNhan;
        public CTPhim()
        {
            InitializeComponent();            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }
        private void CTPhim_Load(object sender, EventArgs e)
        {
            label1.Text = strNhan;
            string id = label1.Text;
            Xuly_Data s = new Xuly_Data();
            Phim p = s.sqlPhim(id);
            label1.Hide();
            //label2.Text = id;
            label2.Text = p.tenphimtv;
            label3.Text = p.tenphimta;
            theloai.Text = p.theloai;
            thoiluong.Text = p.thoiluong;
            phathanh.Text = p.phathanh.ToString();
            daodien.Text = p.daodien;
            dienvien.Text = p.dienvien;           
            sosao.Text = p.sao.ToString();
            luotxem.Text = p.luotxem.ToString();
            luotthich.Text = p.yeuthich.ToString();
            pictureBox1.ImageLocation = p.hinhanh;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            richTextBox_mota.Text = p.mota;

            // Xy ly phan sao

            sosao.Text = p.sao.ToString("N1");
            if ((p.sao>=1) && (p.sao< 2))
            {
                sao1.IconChar = IconChar.Star;
                sao1.IconColor = Color.FromArgb(252, 252, 0);
            } else
                if ((p.sao >=2) && (p.sao <3))
            {
                sao1.IconChar = IconChar.Star;
                sao1.IconColor = Color.FromArgb(252, 252, 0);
                sao2.IconChar = IconChar.Star;
                sao2.IconColor = Color.FromArgb(252, 252, 0);
            } else
                 if ((p.sao >= 3) && (p.sao < 4))
            {
                sao1.IconChar = IconChar.Star;
                sao1.IconColor = Color.FromArgb(252, 252, 0);
                sao2.IconChar = IconChar.Star;
                sao2.IconColor = Color.FromArgb(252, 252, 0);
                sao3.IconChar = IconChar.Star;
                sao3.IconColor = Color.FromArgb(252, 252, 0);
            } else
                if ((p.sao >= 4) && (p.sao < 5))
            {
                sao1.IconChar = IconChar.Star;
                sao1.IconColor = Color.FromArgb(252, 252, 0);
                sao2.IconChar = IconChar.Star;
                sao2.IconColor = Color.FromArgb(252, 252, 0);
                sao3.IconChar = IconChar.Star;
                sao3.IconColor = Color.FromArgb(252, 252, 0);
                sao4.IconChar = IconChar.Star;
                sao4.IconColor = Color.FromArgb(252, 252, 0);
            }else
                if (p.sao >= 5)
            {
                sao1.IconChar = IconChar.Star;
                sao1.IconColor = Color.FromArgb(252, 252, 0);
                sao2.IconChar = IconChar.Star;
                sao2.IconColor = Color.FromArgb(252, 252, 0);
                sao3.IconChar = IconChar.Star;
                sao3.IconColor = Color.FromArgb(252, 252, 0);
                sao4.IconChar = IconChar.Star;
                sao4.IconColor = Color.FromArgb(252, 252, 0);
                sao5.IconChar = IconChar.Star;
                sao5.IconColor = Color.FromArgb(252, 252, 0);
            }
        }        

        private void iconButton_Close_MouseHover(object sender, EventArgs e)
        {
            iconButton_Close.BackColor = Color.FromArgb(189, 23, 70);
        }

        private void iconButton_Close_Click(object sender, EventArgs e)
        {
                this.Close();            
        }

        private void iconButton_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton_Close_MouseLeave(object sender, EventArgs e)
        {
            iconButton_Close.BackColor = Color.FromArgb(35, 40, 52);
        }

        private void iconButton_mini_MouseHover(object sender, EventArgs e)
        {
            iconButton_mini.BackColor = Color.FromArgb(201, 205, 212);
        }

        private void iconButton_mini_MouseLeave(object sender, EventArgs e)
        {
            iconButton_mini.BackColor = Color.FromArgb(35, 40, 52);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string id = label1.Text;
            Xuly_Data s = new Xuly_Data();
            Phim p = s.sqlPhim(id);
            s.tangluotxem(p.idphim, p.luotxem);
            s.themdaxem(p.idphim);
            luotxem.Text = (p.luotxem + 1).ToString();
            XemPhim ct = new XemPhim();
            ct.Message = p.idphim.ToString();
            ct.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themyeuthich_Click(object sender, EventArgs e)
        {
            string id = label1.Text;
            Xuly_Data s = new Xuly_Data();
            Phim p = s.sqlPhim(id);
            s.tangluotthich(p.idphim, p.yeuthich);
            s.themyeuthich(p.idphim);
            Notification ct = new Notification();
            ct.Message = "Đã thêm vào yêu thích";
            ct.Show();
            themyeuthich.Hide();
        }
    }
}
