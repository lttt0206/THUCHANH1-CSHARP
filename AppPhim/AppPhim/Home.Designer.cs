
namespace AppPhim
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.search_text = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton_mini = new FontAwesome.Sharp.IconButton();
            this.iconButton_Close = new FontAwesome.Sharp.IconButton();
            this.iconButton_account = new FontAwesome.Sharp.IconButton();
            this.iconButton_tvshow = new FontAwesome.Sharp.IconButton();
            this.iconButton_anime = new FontAwesome.Sharp.IconButton();
            this.iconButton_chieurap = new FontAwesome.Sharp.IconButton();
            this.iconButton_phimle = new FontAwesome.Sharp.IconButton();
            this.iconButton_phimbo = new FontAwesome.Sharp.IconButton();
            this.bt_phimmoi = new FontAwesome.Sharp.IconButton();
            this.pictureBox_Home = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 3;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.iconButton_account);
            this.panelMenu.Controls.Add(this.iconButton_tvshow);
            this.panelMenu.Controls.Add(this.iconButton_anime);
            this.panelMenu.Controls.Add(this.iconButton_chieurap);
            this.panelMenu.Controls.Add(this.iconButton_phimle);
            this.panelMenu.Controls.Add(this.iconButton_phimbo);
            this.panelMenu.Controls.Add(this.bt_phimmoi);
            this.panelMenu.Controls.Add(this.pictureBox_Home);
            this.panelMenu.Location = new System.Drawing.Point(0, 25);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(984, 52);
            this.panelMenu.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDesktop.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesktop.Location = new System.Drawing.Point(0, 95);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(984, 546);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Location = new System.Drawing.Point(-3, 78);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(0, 13);
            this.lblTitleChildForm.TabIndex = 2;
            // 
            // search_text
            // 
            this.search_text.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.search_text.Location = new System.Drawing.Point(656, 90);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(268, 32);
            this.search_text.StateActive.Border.Color1 = System.Drawing.Color.White;
            this.search_text.StateActive.Border.Color2 = System.Drawing.Color.White;
            this.search_text.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_text.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.search_text.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.search_text.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.search_text.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_text.StateCommon.Border.Rounding = 10;
            this.search_text.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_text.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.search_text.TabIndex = 3;
            this.search_text.Text = "Tìm kiếm ...";
            this.search_text.WordWrap = false;
            this.search_text.Enter += new System.EventHandler(this.search_text_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.iconButton_mini);
            this.panel1.Controls.Add(this.iconButton_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 22);
            this.panel1.TabIndex = 7;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton7.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconSize = 25;
            this.iconButton7.Location = new System.Drawing.Point(928, 88);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Rotation = 0D;
            this.iconButton7.Size = new System.Drawing.Size(38, 39);
            this.iconButton7.TabIndex = 6;
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppPhim.Properties.Resources.Surrender__2_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // iconButton_mini
            // 
            this.iconButton_mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.iconButton_mini.FlatAppearance.BorderSize = 0;
            this.iconButton_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_mini.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_mini.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_mini.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_mini.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton_mini.IconColor = System.Drawing.Color.White;
            this.iconButton_mini.IconSize = 15;
            this.iconButton_mini.Location = new System.Drawing.Point(897, 0);
            this.iconButton_mini.Name = "iconButton_mini";
            this.iconButton_mini.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iconButton_mini.Rotation = 0D;
            this.iconButton_mini.Size = new System.Drawing.Size(42, 22);
            this.iconButton_mini.TabIndex = 9;
            this.iconButton_mini.UseVisualStyleBackColor = false;
            this.iconButton_mini.Click += new System.EventHandler(this.iconButton_mini_Click);
            this.iconButton_mini.MouseLeave += new System.EventHandler(this.iconButton_mini_MouseLeave);
            this.iconButton_mini.MouseHover += new System.EventHandler(this.iconButton_mini_MouseHover);
            // 
            // iconButton_Close
            // 
            this.iconButton_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.iconButton_Close.FlatAppearance.BorderSize = 0;
            this.iconButton_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_Close.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton_Close.IconColor = System.Drawing.Color.White;
            this.iconButton_Close.IconSize = 15;
            this.iconButton_Close.Location = new System.Drawing.Point(942, 0);
            this.iconButton_Close.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_Close.Name = "iconButton_Close";
            this.iconButton_Close.Rotation = 0D;
            this.iconButton_Close.Size = new System.Drawing.Size(42, 22);
            this.iconButton_Close.TabIndex = 8;
            this.iconButton_Close.UseVisualStyleBackColor = false;
            this.iconButton_Close.Click += new System.EventHandler(this.iconButton_Close_Click);
            this.iconButton_Close.MouseLeave += new System.EventHandler(this.iconButton_Close_MouseLeave);
            this.iconButton_Close.MouseHover += new System.EventHandler(this.iconButton_Close_MouseHover);
            // 
            // iconButton_account
            // 
            this.iconButton_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iconButton_account.FlatAppearance.BorderSize = 0;
            this.iconButton_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_account.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_account.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_account.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton_account.IconColor = System.Drawing.Color.White;
            this.iconButton_account.IconSize = 30;
            this.iconButton_account.Location = new System.Drawing.Point(928, 0);
            this.iconButton_account.Name = "iconButton_account";
            this.iconButton_account.Rotation = 0D;
            this.iconButton_account.Size = new System.Drawing.Size(49, 52);
            this.iconButton_account.TabIndex = 5;
            this.iconButton_account.UseVisualStyleBackColor = false;
            // 
            // iconButton_tvshow
            // 
            this.iconButton_tvshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iconButton_tvshow.FlatAppearance.BorderSize = 0;
            this.iconButton_tvshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_tvshow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_tvshow.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_tvshow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_tvshow.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_tvshow.IconColor = System.Drawing.Color.Black;
            this.iconButton_tvshow.IconSize = 16;
            this.iconButton_tvshow.Location = new System.Drawing.Point(784, 0);
            this.iconButton_tvshow.Name = "iconButton_tvshow";
            this.iconButton_tvshow.Rotation = 0D;
            this.iconButton_tvshow.Size = new System.Drawing.Size(122, 52);
            this.iconButton_tvshow.TabIndex = 4;
            this.iconButton_tvshow.Text = "TV Show";
            this.iconButton_tvshow.UseVisualStyleBackColor = false;
            this.iconButton_tvshow.Click += new System.EventHandler(this.iconButton_tvshow_Click);
            // 
            // iconButton_anime
            // 
            this.iconButton_anime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iconButton_anime.FlatAppearance.BorderSize = 0;
            this.iconButton_anime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_anime.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_anime.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_anime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_anime.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_anime.IconColor = System.Drawing.Color.Black;
            this.iconButton_anime.IconSize = 16;
            this.iconButton_anime.Location = new System.Drawing.Point(656, 0);
            this.iconButton_anime.Name = "iconButton_anime";
            this.iconButton_anime.Rotation = 0D;
            this.iconButton_anime.Size = new System.Drawing.Size(122, 52);
            this.iconButton_anime.TabIndex = 3;
            this.iconButton_anime.Text = "Anime";
            this.iconButton_anime.UseVisualStyleBackColor = false;
            this.iconButton_anime.Click += new System.EventHandler(this.iconButton_anime_Click);
            // 
            // iconButton_chieurap
            // 
            this.iconButton_chieurap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iconButton_chieurap.FlatAppearance.BorderSize = 0;
            this.iconButton_chieurap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_chieurap.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_chieurap.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_chieurap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_chieurap.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_chieurap.IconColor = System.Drawing.Color.Black;
            this.iconButton_chieurap.IconSize = 16;
            this.iconButton_chieurap.Location = new System.Drawing.Point(528, 0);
            this.iconButton_chieurap.Name = "iconButton_chieurap";
            this.iconButton_chieurap.Rotation = 0D;
            this.iconButton_chieurap.Size = new System.Drawing.Size(122, 52);
            this.iconButton_chieurap.TabIndex = 3;
            this.iconButton_chieurap.Text = "Chiếu rạp";
            this.iconButton_chieurap.UseVisualStyleBackColor = false;
            this.iconButton_chieurap.Click += new System.EventHandler(this.iconButton_chieurap_Click);
            // 
            // iconButton_phimle
            // 
            this.iconButton_phimle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iconButton_phimle.FlatAppearance.BorderSize = 0;
            this.iconButton_phimle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_phimle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_phimle.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_phimle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_phimle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_phimle.IconColor = System.Drawing.Color.Black;
            this.iconButton_phimle.IconSize = 16;
            this.iconButton_phimle.Location = new System.Drawing.Point(400, 0);
            this.iconButton_phimle.Name = "iconButton_phimle";
            this.iconButton_phimle.Rotation = 0D;
            this.iconButton_phimle.Size = new System.Drawing.Size(122, 52);
            this.iconButton_phimle.TabIndex = 3;
            this.iconButton_phimle.Text = "Phim lẻ";
            this.iconButton_phimle.UseVisualStyleBackColor = false;
            this.iconButton_phimle.Click += new System.EventHandler(this.iconButton_phimle_Click);
            // 
            // iconButton_phimbo
            // 
            this.iconButton_phimbo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iconButton_phimbo.FlatAppearance.BorderSize = 0;
            this.iconButton_phimbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_phimbo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton_phimbo.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton_phimbo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton_phimbo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton_phimbo.IconColor = System.Drawing.Color.Black;
            this.iconButton_phimbo.IconSize = 16;
            this.iconButton_phimbo.Location = new System.Drawing.Point(272, 0);
            this.iconButton_phimbo.Name = "iconButton_phimbo";
            this.iconButton_phimbo.Rotation = 0D;
            this.iconButton_phimbo.Size = new System.Drawing.Size(122, 52);
            this.iconButton_phimbo.TabIndex = 2;
            this.iconButton_phimbo.Text = "Phim bộ";
            this.iconButton_phimbo.UseVisualStyleBackColor = false;
            this.iconButton_phimbo.Click += new System.EventHandler(this.iconButton_phimbo_Click);
            // 
            // bt_phimmoi
            // 
            this.bt_phimmoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bt_phimmoi.FlatAppearance.BorderSize = 0;
            this.bt_phimmoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_phimmoi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bt_phimmoi.Font = new System.Drawing.Font("Nunito ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_phimmoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_phimmoi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bt_phimmoi.IconColor = System.Drawing.Color.Black;
            this.bt_phimmoi.IconSize = 16;
            this.bt_phimmoi.Location = new System.Drawing.Point(144, 0);
            this.bt_phimmoi.Name = "bt_phimmoi";
            this.bt_phimmoi.Rotation = 0D;
            this.bt_phimmoi.Size = new System.Drawing.Size(122, 52);
            this.bt_phimmoi.TabIndex = 1;
            this.bt_phimmoi.Text = "Phim mới";
            this.bt_phimmoi.UseVisualStyleBackColor = false;
            this.bt_phimmoi.Click += new System.EventHandler(this.iconButton_phimmoi_Click);
            // 
            // pictureBox_Home
            // 
            this.pictureBox_Home.Image = global::AppPhim.Properties.Resources.logo1;
            this.pictureBox_Home.Location = new System.Drawing.Point(10, -6);
            this.pictureBox_Home.Name = "pictureBox_Home";
            this.pictureBox_Home.Size = new System.Drawing.Size(101, 70);
            this.pictureBox_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Home.TabIndex = 0;
            this.pictureBox_Home.TabStop = false;
            this.pictureBox_Home.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.iconButton7);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitleChildForm);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Cornsilk;
            this.Load += new System.EventHandler(this.Home_Load_1);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox_Home;
        private FontAwesome.Sharp.IconButton bt_phimmoi;
        private FontAwesome.Sharp.IconButton iconButton_anime;
        private FontAwesome.Sharp.IconButton iconButton_chieurap;
        private FontAwesome.Sharp.IconButton iconButton_phimle;
        private FontAwesome.Sharp.IconButton iconButton_phimbo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButton_tvshow;
        private FontAwesome.Sharp.IconButton iconButton_account;
        private FontAwesome.Sharp.IconButton iconButton7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox search_text;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton_mini;
        private FontAwesome.Sharp.IconButton iconButton_Close;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

