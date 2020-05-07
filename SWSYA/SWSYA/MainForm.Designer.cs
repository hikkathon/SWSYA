namespace SWSYA
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnReestablish = new System.Windows.Forms.PictureBox();
            this.VerticalSplashPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnime = new System.Windows.Forms.Button();
            this.ContentedPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReestablish)).BeginInit();
            this.VerticalSplashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.btnMaximize);
            this.TopPanel.Controls.Add(this.btnMenu);
            this.TopPanel.Controls.Add(this.btnMinimize);
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.btnReestablish);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 37);
            this.TopPanel.TabIndex = 4;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SWSAY";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = global::SWSYA.Properties.Resources.icons8_развернуть_окно_96;
            this.btnMaximize.Location = new System.Drawing.Point(756, 11);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(15, 15);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::SWSYA.Properties.Resources.icons8_menu_50;
            this.btnMenu.Location = new System.Drawing.Point(85, 11);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(15, 15);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::SWSYA.Properties.Resources.icons8_свернуть_окно_96;
            this.btnMinimize.Location = new System.Drawing.Point(735, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::SWSYA.Properties.Resources.icons8_закрыть_окно_96;
            this.btnClose.Location = new System.Drawing.Point(777, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReestablish
            // 
            this.btnReestablish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReestablish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReestablish.Image = global::SWSYA.Properties.Resources.icons8_восстановить_окно_96;
            this.btnReestablish.Location = new System.Drawing.Point(756, 11);
            this.btnReestablish.Name = "btnReestablish";
            this.btnReestablish.Size = new System.Drawing.Size(15, 15);
            this.btnReestablish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReestablish.TabIndex = 0;
            this.btnReestablish.TabStop = false;
            this.btnReestablish.Visible = false;
            this.btnReestablish.Click += new System.EventHandler(this.btnReestablish_Click);
            // 
            // VerticalSplashPanel
            // 
            this.VerticalSplashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.VerticalSplashPanel.Controls.Add(this.button4);
            this.VerticalSplashPanel.Controls.Add(this.button3);
            this.VerticalSplashPanel.Controls.Add(this.button2);
            this.VerticalSplashPanel.Controls.Add(this.button1);
            this.VerticalSplashPanel.Controls.Add(this.btnAnime);
            this.VerticalSplashPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerticalSplashPanel.Location = new System.Drawing.Point(0, 37);
            this.VerticalSplashPanel.Name = "VerticalSplashPanel";
            this.VerticalSplashPanel.Size = new System.Drawing.Size(150, 413);
            this.VerticalSplashPanel.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.button4.Image = global::SWSYA.Properties.Resources.icons8_метка_96;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.button3.Image = global::SWSYA.Properties.Resources.icons8_сетка_4x4_96;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Tables";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.button2.Image = global::SWSYA.Properties.Resources.icons8_спидометр_96;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.button1.Image = global::SWSYA.Properties.Resources.icons8_настройки_64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Setting";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAnime
            // 
            this.btnAnime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnAnime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAnime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.btnAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnAnime.Image = global::SWSYA.Properties.Resources.icons8_метка_96;
            this.btnAnime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnime.Location = new System.Drawing.Point(0, 335);
            this.btnAnime.Name = "btnAnime";
            this.btnAnime.Size = new System.Drawing.Size(150, 30);
            this.btnAnime.TabIndex = 1;
            this.btnAnime.Text = "Anime";
            this.btnAnime.UseVisualStyleBackColor = true;
            this.btnAnime.Click += new System.EventHandler(this.btnAnime_Click);
            // 
            // ContentedPanel
            // 
            this.ContentedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ContentedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentedPanel.Location = new System.Drawing.Point(150, 37);
            this.ContentedPanel.Name = "ContentedPanel";
            this.ContentedPanel.Size = new System.Drawing.Size(650, 413);
            this.ContentedPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentedPanel);
            this.Controls.Add(this.VerticalSplashPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReestablish)).EndInit();
            this.VerticalSplashPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnReestablish;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Button btnAnime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel VerticalSplashPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ContentedPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

