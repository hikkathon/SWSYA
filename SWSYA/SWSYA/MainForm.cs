using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SWSYA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public delegate void NotificationDelegate(string title, string message, string song, NotificationForm.enmType type);

        public void Notification(string title, string message, NotificationForm.enmType type)
        {
            NotificationForm frm = new NotificationForm();
            frm.NotificationShow(title, message, type);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (VerticalSplashPanel.Width == 150)
            {
                VerticalSplashPanel.Width = 39;
            }
            else
            {
                VerticalSplashPanel.Width = 150;
            }
        }

        #region btnTop
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnReestablish.Visible = true;
            btnMaximize.Visible = false;
        }

        private void btnReestablish_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnReestablish.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.ContentedPanel.Controls.Count > 0)
            {
                this.ContentedPanel.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.ContentedPanel.Controls.Add(fh);
            fh.Show();
        }

        private void btnAnime_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new AnimeForm());
            Notification("Новое уведомление", "Спасибо, ваш голос учтен", NotificationForm.enmType.Info);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (VerticalSplashPanel.Width == 150)
            {
                VerticalSplashPanel.Width = 50;
            }
            else
            {
                VerticalSplashPanel.Width = 150;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
