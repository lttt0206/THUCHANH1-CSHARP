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
    public partial class Phimbo : KryptonForm
    {
        private IconButton currentBtn;
        private Form currentChildForm;

        public Phimbo()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
            
       
        
        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void label_main_Click(object sender, EventArgs e)
        {

        }
    }
}
