using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSYA
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
            TopMost = true;
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Info,
            Warning,
            Success,
            Error
        }

        private NotificationForm.enmAction action;

        private int x, y;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 10000;
                    action = enmAction.close;
                    break;

                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;

                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void NotificationShow(string title, string message, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            int counter = 1;
            for (int i = 0; i < 15; i++)
            {
                counter+=1;
                fname = "alert" + i.ToString();
                NotificationForm frm = (NotificationForm)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 100 + this.Size.Height - counter;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 1;

            switch (type)
            {
                case enmType.Info:
                    //this.pictureBox1.Image = Resources.success;
                    //this.panel2.BackColor = Color.FromArgb(51, 181, 229);
                    //this.BackColor = Color.FromArgb(227, 227, 227);
                    break;
                case enmType.Warning:
                    //this.pictureBox1.Image = Resources.error;
                    //this.panel2.BackColor = Color.FromArgb(255, 187, 51);
                    //this.BackColor = Color.FromArgb(227, 227, 227);
                    break;
                case enmType.Success:
                    //this.pictureBox1.Image = Resources.info;
                    //this.panel2.BackColor = Color.FromArgb(0, 200, 81);
                    //this.BackColor = Color.FromArgb(227, 227, 227);
                    break;
                case enmType.Error:
                    //this.pictureBox1.Image = Resources.warning;
                    //this.panel2.BackColor = Color.FromArgb(255, 53, 71);
                    //this.BackColor = Color.FromArgb(227, 227, 227);
                    break;
            }

            this.lblMessage.Text = message;
            this.lblTitle.Text = title;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}
