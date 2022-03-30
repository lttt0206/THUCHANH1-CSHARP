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
    public partial class Home : KryptonForm
    {
        private IconButton currentBtn;
        private Form currentChildForm;

        public Home()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Xuly_Data s = new Xuly_Data();
            List<Phim> list = s.sqlPhimxemnhieu();
            int i = 0;
            if (list.Count > i)
            {
                pictureBox1.ImageLocation = list[i].hinhanh;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label1.Text = list[i].tenphimtv;
                i++;
                //label_trong.Hide();
            }
            else
            {
                label1.Text = "";
                //label_trong.Text = "Chưa có dữ liệu phim";
            }

            if (list.Count > i)
            {
                pictureBox3.ImageLocation = list[i].hinhanh;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                label2.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label2.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox4.ImageLocation = list[i].hinhanh;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                label3.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label3.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox5.ImageLocation = list[i].hinhanh;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                label4.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label4.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox6.ImageLocation = list[i].hinhanh;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                label5.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label5.Text = "";
            }

            if (list.Count > i)
            {
                pictureBox7.ImageLocation = list[i].hinhanh;
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                label6.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label6.Text = "";
            }

            // Phim yeu thich nhat

            Xuly_Data st = new Xuly_Data();
            list = st.sqlPhimyeuthich();
            i = 0;
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

            if (list.Count > i)
            {
                pictureBox13.ImageLocation = list[i].hinhanh;
                pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
                label9.Text = list[i].tenphimtv;
                i++;
            }
            else
            {
                label13.Text = "";
            }
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 51);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {            
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void iconButton_phimmoi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new Phimmoi());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
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
                Application.Exit();
            }
            else
            {
                // Do something  
            }
            
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

        private void iconButton_phimbo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new Phimbo());
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            DisableButton();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Invalidate();
        }
        private void search_text_Enter(object sender, EventArgs e)
        {
            search_text.Text = "";
        }

        private void iconButton_anime_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new Anime());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }

        private void iconButton_phimle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new Phimle());
        }

        private void iconButton_chieurap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new Chieurap());
        }

        private void iconButton_tvshow_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new TVShow());
        }

        private void iconButton_account_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(172, 126, 241));
            OpenChildForm(new TaikhoanUI());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[0].idphim.ToString();
                ct.Show();
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!label2.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[1].idphim.ToString();
                ct.Show();
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (!label3.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[2].idphim.ToString();
                ct.Show();
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!label4.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[3].idphim.ToString();
                ct.Show();
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!label5.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[4].idphim.ToString();
                ct.Show();
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (!label6.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[5].idphim.ToString();
                ct.Show();
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (!label8.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimyeuthich();
                CTPhim ct = new CTPhim();
                ct.Message = list[0].idphim.ToString();
                ct.Show();
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (!label9.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[1].idphim.ToString();
                ct.Show();
            }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (!label10.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[2].idphim.ToString();
                ct.Show();
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel11_Click(object sender, EventArgs e)
        {

            if (!label11.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
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
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[4].idphim.ToString();
                ct.Show();
            }
        }

        private void panel13_Click(object sender, EventArgs e)
        {

            if (!label13.Text.Equals(""))
            {
                Xuly_Data s = new Xuly_Data();
                List<Phim> list = s.sqlPhimxemnhieu();
                CTPhim ct = new CTPhim();
                ct.Message = list[5].idphim.ToString();
                ct.Show();
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Timkiem ct = new Timkiem();            

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ct;

            ct.TopLevel = false;
            ct.FormBorderStyle = FormBorderStyle.None;
            ct.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ct);
            panelDesktop.Tag = ct;
            ct.Message = search_text.Text;
            ct.BringToFront();
            ct.Show();
        }
    }
}
