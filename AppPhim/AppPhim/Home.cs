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
    }
}
