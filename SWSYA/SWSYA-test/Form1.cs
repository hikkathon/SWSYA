using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWSYA_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> hrefitem = new List<string>();

        public delegate void AddMessageTestDelegate(string message);
        public void MessageTest(string message)
        {
            toolStripStatusLabelElementCounter.Text = message;
        }

        public void StartParse()
        {
            var sw = new Stopwatch();

            int StartPage = Convert.ToInt32(toolStripTextBoxStartPage.Text);
            int EndPage = Convert.ToInt32(toolStripTextBoxEndPage.Text);


            HtmlWeb web = new HtmlWeb();

            var html = toolStripTextBoxURL.Text;

            int testCounter = 0;
            sw.Start();
            for (int i = StartPage; i <= EndPage; i++)
            {
                var htmlDoc = web.Load(html + "/catalog?page=" + i);
                var posts = htmlDoc.DocumentNode.SelectNodes(".//div[@class='content-page categories-page']/div[@class='anime-column']"); // в переменную post парсим аниме из каталога

                if (posts==null)
                {
                    Invoke(new AddMessageTestDelegate(MessageTest), new object[] { testCounter.ToString() + " Wait..."});
                    Thread.Sleep(40000);
                    htmlDoc = web.Load(html + "/catalog?page=" + i);
                    posts = htmlDoc.DocumentNode.SelectNodes(".//div[@class='content-page categories-page']/div[@class='anime-column']"); // в переменную post парсим аниме из каталога
                }

                foreach (var post in posts)
                {
                    var _hrefitem = post.SelectSingleNode("./a[@class='image-block']")?.GetAttributes("href"); // вытягиваем ссылки на страницу с аниме
                    hrefitem.Add(html + _hrefitem.ElementAt(0).Value);
                    testCounter++;
                    Thread.Sleep(5);
                    Invoke(new AddMessageTestDelegate(MessageTest), new object[] { testCounter.ToString() });
                }
            }
            sw.Stop();
            MessageBox.Show(
                    $"Time spent: {sw.ElapsedMilliseconds}ms.",
                    "Stopwatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            Task task = new Task(() => StartParse());
            task.Start();
        }

        private void toolStripTextBoxURL_DoubleClick(object sender, EventArgs e)
        {
            toolStripTextBoxURL.Text = "https://yummyanime.club";
        }
    }
}
