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
    public partial class XemPhim: KryptonForm
    {
        string strNhan;
        public XemPhim()
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
        private void XemPhim_Load(object sender, EventArgs e)
        {
            label1.Text = strNhan;
            string id = label1.Text;
            Xuly_Data s = new Xuly_Data();
            Phim p = s.sqlPhim(id);
            label1.Hide();
            //label2.Text = id;
            label2.Text = p.tenphimtv;
            sosao.Text = p.sao.ToString();
            MediaPlayer.URL = p.linkphim;
        }

        private void iconButton_Close_MouseHover(object sender, EventArgs e)
        {
            iconButton_Close.BackColor = Color.FromArgb(189, 23, 70);
        }

        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MediaPlayer.Ctlcontrols.pause();
                this.Close();
            }
            else
            {
                // Do something  
            }
            
            //this.Close(); 
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

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sao1_MouseHover(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.Star;
            sao1.IconColor = Color.FromArgb(252, 252, 0);
            sosao.Text = "1";
        }

        private void sao1_MouseLeave(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.StarO;
            sao1.IconColor = Color.FromArgb(247, 247, 233);
            sosao.Text = "0";
        }

        private void sao2_MouseHover(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.Star;
            sao1.IconColor = Color.FromArgb(252, 252, 0);
            sao2.IconChar = IconChar.Star;
            sao2.IconColor = Color.FromArgb(252, 252, 0);
            sosao.Text = "2";
        }

        private void sao2_MouseLeave(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.StarO;
            sao1.IconColor = Color.FromArgb(247, 247, 233);
            sao2.IconChar = IconChar.StarO;
            sao2.IconColor = Color.FromArgb(247, 247, 233);
            sosao.Text = "0";
        }

        private void sao3_MouseHover(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.Star;
            sao1.IconColor = Color.FromArgb(252, 252, 0);
            sao2.IconChar = IconChar.Star;
            sao2.IconColor = Color.FromArgb(252, 252, 0);
            sao3.IconChar = IconChar.Star;
            sao3.IconColor = Color.FromArgb(252, 252, 0);
            sosao.Text = "3";
        }

        private void sao3_MouseLeave(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.StarO;
            sao1.IconColor = Color.FromArgb(247, 247, 233);
            sao2.IconChar = IconChar.StarO;
            sao3.IconChar = IconChar.StarO;
            sao2.IconColor = Color.FromArgb(247, 247, 233);
            sao3.IconColor = Color.FromArgb(247, 247, 233);
            sosao.Text = "0";
        }

        private void sao4_MouseHover(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.Star;
            sao1.IconColor = Color.FromArgb(252, 252, 0);
            sao2.IconChar = IconChar.Star;
            sao2.IconColor = Color.FromArgb(252, 252, 0);
            sao3.IconChar = IconChar.Star;
            sao3.IconColor = Color.FromArgb(252, 252, 0);
            sao4.IconChar = IconChar.Star;
            sao4.IconColor = Color.FromArgb(252, 252, 0);
            sosao.Text = "3";
        }

        private void sao4_MouseLeave(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.StarO;
            sao1.IconColor = Color.FromArgb(247, 247, 233);
            sao2.IconChar = IconChar.StarO;
            sao3.IconChar = IconChar.StarO;
            sao2.IconColor = Color.FromArgb(247, 247, 233);
            sao3.IconColor = Color.FromArgb(247, 247, 233);
            sao4.IconChar = IconChar.StarO;
            sao4.IconColor = Color.FromArgb(247, 247, 233);
            sosao.Text = "0";
        }

        private void sao5_MouseHover(object sender, EventArgs e)
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
            sosao.Text = "5";
        }

        private void sao5_MouseLeave(object sender, EventArgs e)
        {
            sao1.IconChar = IconChar.StarO;
            sao1.IconColor = Color.FromArgb(247, 247, 233);
            sao2.IconChar = IconChar.StarO;
            sao3.IconChar = IconChar.StarO;
            sao2.IconColor = Color.FromArgb(247, 247, 233);
            sao3.IconColor = Color.FromArgb(247, 247, 233);
            sao4.IconChar = IconChar.StarO;
            sao4.IconColor = Color.FromArgb(247, 247, 233);
            sao5.IconChar = IconChar.StarO;
            sao5.IconColor = Color.FromArgb(247, 247, 233);
            sosao.Text = "0";
        }

        private void MediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            MediaPlayer.Ctlcontrols.pause();
        }
    }
}
