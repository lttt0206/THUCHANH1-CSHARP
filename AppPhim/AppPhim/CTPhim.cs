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
            pictureBox1.ImageLocation = p.hinhanh;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

    }
}
