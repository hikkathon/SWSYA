using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        List<string> hrefitems = new List<string>();

        FormProgress fp = new FormProgress();
        RemoveSpaces rs = new RemoveSpaces();

        public delegate void ShowDataViewGridDelegate(int counter, string title, string rating, string vote, string aTitle, string view, string status, string released, string season, string ageRating, string genre, string primarySourse, string studio, string producer, string type, string series, string transfer, string voiceActing, string description, string urlimage, string license, string lAnime );
        public void ShowDataViewGrid(int counter, string title, string rating, string vote, string aTitle, string view, string status, string released, string season, string ageRating, string genre, string primarySourse, string studio, string producer, string type, string series, string transfer, string voiceActing, string description, string urlimage, string license, string lAnime)
        {
            dataGridView1.Rows.Add(counter, title,  rating,  vote,  aTitle,  view,  status,  released,  season,  ageRating,  genre,  primarySourse,  studio,  producer,  type,  series,  transfer,  voiceActing, description,  urlimage,  license,  lAnime);
        }

        public delegate void AddFormProgressDelegate(string url, string count);
        public void FormProgress(string url, string count)
        {            
            labelCountUrl.Text = count;
            labelURL.Text = url;
        }
        public delegate void AddFormProgressDelegate2(string url, string count);
        public void FormProgress2(string url, string count)
        {
            labelCountAnime.Text = count;
            labelNameAnime.Text = url;
        }

        public void StartParse()
        {
            var sw = new Stopwatch();

            int StartPage = Convert.ToInt32(toolStripTextBoxStartPage.Text);
            int EndPage = Convert.ToInt32(toolStripTextBoxEndPage.Text);


            HtmlWeb web = new HtmlWeb();

            var html = toolStripTextBoxURL.Text;

            int testCounter = 0;
            int counterAnime = 0;
            for (int i = StartPage; i <= EndPage; i++)
            {
                var htmlDoc = web.Load(html + "/catalog?page=" + i);
                var posts = htmlDoc.DocumentNode.SelectNodes(".//div[@class='content-page categories-page']/div[@class='anime-column']"); // в переменную post парсим аниме из каталога

                if (posts==null)
                {
                    Thread.Sleep(45000);
                    htmlDoc = web.Load(html + "/catalog?page=" + i);
                    posts = htmlDoc.DocumentNode.SelectNodes(".//div[@class='content-page categories-page']/div[@class='anime-column']"); // в переменную post парсим аниме из каталога
                }

                foreach (var post in posts)
                {
                    var _hrefitem = post.SelectSingleNode("./a[@class='image-block']")?.GetAttributes("href"); // вытягиваем ссылки на страницу с аниме
                    hrefitems.Add(html + _hrefitem.ElementAt(0).Value);
                    testCounter++;
                    Thread.Sleep(5);
                    Invoke(new AddFormProgressDelegate(FormProgress), new object[] { html + _hrefitem.ElementAt(0).Value, $"{testCounter} / " + (EndPage*24).ToString() });
                }
            }
            Invoke(new AddFormProgressDelegate(FormProgress), new object[] { "Готово.", $"{testCounter} / " + (EndPage * 24).ToString() });

            foreach (var hrefitem in hrefitems)
            {
                counterAnime++;
                var htmlDoc = web.Load(hrefitem);

                var alternativeTitle = htmlDoc.DocumentNode.SelectNodes(".//ul[@class='alt-names-list']/li"); // находим альтернативные названия TODO: в некоторых аниме нет алт. названия и вылетает NullReferenceException
                var infolists = htmlDoc.DocumentNode.SelectNodes(".//div/div[@class='content-page anime-page']/ul[@class='content-main-info']/li"); // находим просмотры,статус,сезон,возростной рейтинг,жанр,первоисточник,студия,режиссер,тип,серия,перевод,озвучка
                var title = htmlDoc.DocumentNode.SelectSingleNode("//h1")?.InnerText.Trim(); // находим название 
                if (title == "Нам очень жаль, но страница не найдена :'(")
                {
                    continue;
                }
                var rating = htmlDoc.DocumentNode.SelectSingleNode("//span[@class='main-rating']")?.InnerText.Trim() ?? "Рейтинг недоступен"; // находим рейтинг 
                var vote = htmlDoc.DocumentNode.SelectSingleNode("//span[@class='main-rating-info']")?.InnerText.Trim().Replace("(", string.Empty).Replace(")", string.Empty).Replace("голосов", string.Empty) ?? "Рейтинг недоступен"; // находим количество голосов
                var urlimage = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[3]/div[3]/div/div/div[1]/div[1]/img")?.GetAttributeValue("src", "").Trim(); // находим ссылку на постер
                var description = htmlDoc.DocumentNode.SelectSingleNode(".//div[@class='content-desc']/div[@id='content-desc-text']/p")?.InnerText.Trim(); // находим описание
                description = rs.Remove("", description, " ", 0, 0).Replace("&quot;", string.Empty);
                var license = htmlDoc.DocumentNode.SelectSingleNode(".//div[@id='video']/div[@class='status-bg alert-bg']/text()")?.InnerText.Trim() ?? "Не лицензировано"; // находим инфу о локализаторе в рф
                license = rs.Remove("", license, " ", 0, 0);


                if (infolists==null)
                {
                    Thread.Sleep(50000);

                    htmlDoc = web.Load(hrefitem);

                    alternativeTitle = htmlDoc.DocumentNode.SelectNodes(".//ul[@class='alt-names-list']/li"); // находим альтернативные названия TODO: в некоторых аниме нет алт. названия и вылетает NullReferenceException
                    infolists = htmlDoc.DocumentNode.SelectNodes(".//div/div[@class='content-page anime-page']/ul[@class='content-main-info']/li"); // находим просмотры,статус,сезон,возростной рейтинг,жанр,первоисточник,студия,режиссер,тип,серия,перевод,озвучка
                    title = htmlDoc.DocumentNode.SelectSingleNode("//h1")?.InnerText.Trim(); // находим название 
                    rating = htmlDoc.DocumentNode.SelectSingleNode("//span[@class='main-rating']")?.InnerText.Trim() ?? "Рейтинг недоступен"; // находим рейтинг 
                    vote = htmlDoc.DocumentNode.SelectSingleNode("//span[@class='main-rating-info']")?.InnerText.Trim().Replace("(", string.Empty).Replace(")", string.Empty).Replace("голосов", string.Empty) ?? "Рейтинг недоступен"; // находим количество голосов
                    urlimage = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[3]/div[3]/div/div/div[1]/div[1]/img")?.GetAttributeValue("src", "").Trim(); // находим ссылку на постер
                    description = htmlDoc.DocumentNode.SelectSingleNode(".//div[@class='content-desc']/div[@id='content-desc-text']/p")?.InnerText.Trim(); // находим описание
                    description = rs.Remove("", description, " ", 0, 0).Replace("&quot;", string.Empty);
                    license = htmlDoc.DocumentNode.SelectSingleNode(".//div[@id='video']/div[@class='status-bg alert-bg']/text()")?.InnerText.Trim() ?? "Не лицензировано"; // находим инфу о локализаторе в рф
                    license = rs.Remove("", license, " ", 0, 0);
                }


                string view = "нет данных";
                string status = "нет данных";
                string released = "нет данных";
                string season = "нет данных";
                string ageRating = "нет данных";
                string genre = "нет данных";
                string primarySourse = "нет данных";
                string studio = "нет данных";
                string producer = "нет данных";
                string type = "нет данных";
                string series = "нет данных";
                string transfer = "нет данных";
                string voiceActing = "нет данных";
                string aTitle = "нет данных";
                string lAnime = hrefitem ?? "нет данных";

                List<string> temptitle = new List<string>();

                if (alternativeTitle == null)
                {

                }
                else
                {
                    foreach (var titlelist in alternativeTitle)
                    {
                        if (titlelist != null)
                        {
                            temptitle.Add(titlelist.InnerText);
                            temptitle.Remove("...");
                            aTitle = String.Join(" ,", temptitle.ToArray());
                        }
                    }
                }
                                
                foreach (var infolist in infolists)
                {
                    var tempinfolist = infolist.InnerText.Trim().Replace("\r\n", string.Empty);
                    var selection = tempinfolist.Substring(0, tempinfolist.IndexOf(":") + 1);

                    switch (selection)
                    {
                        case "Просмотров:":
                            view = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Replace(" ", string.Empty);
                            break;
                        case "Статус:":
                            status = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Год:":
                            released = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Сезон:":
                            season = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Возрастной рейтинг:":
                            ageRating = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Жанр:":
                            //genre = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            genre = rs.Remove(",", tempinfolist, " ", 0, 3).Substring(tempinfolist.IndexOf(":") + 1);
                            break;
                        case "Первоисточник:":
                            primarySourse = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Студия:":
                            studio = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Режиссер:":
                            producer = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Тип:":
                            type = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Серии:":
                            series = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            break;
                        case "Перевод:":
                            //transfer = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim();
                            //transfer = string.Join(", ", transfer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                            transfer = rs.Remove(",", tempinfolist, " ", 0, 3).Substring(tempinfolist.IndexOf(":") + 1);
                            break;
                        case "Озвучка:":
                            voiceActing = tempinfolist.Substring(tempinfolist.IndexOf(":") + 1).Trim().Replace("amp;", string.Empty);
                            break;
                        default:
                            MessageBox.Show("Что то пошло не так!", "Exception Caught!",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning,
                                       MessageBoxDefaultButton.Button1,
                                       MessageBoxOptions.DefaultDesktopOnly);
                            break;
                    }
                }
                Invoke(new ShowDataViewGridDelegate(ShowDataViewGrid), new object[] { counterAnime ,title, rating, vote, aTitle, view, status, released, season, ageRating, genre, primarySourse, studio, producer, type, series, transfer, voiceActing, description, labelURL.Text+urlimage, license, lAnime });
                Invoke(new AddFormProgressDelegate2(FormProgress2), new object[] { title, $"{counterAnime} / " + (EndPage * 24).ToString() });
            }
            Invoke(new AddFormProgressDelegate2(FormProgress2), new object[] { "Готово.", $"{counterAnime} / " + (EndPage * 24).ToString() });
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

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;

            try
            {
                ws = wb.ActiveSheet;
                ws.Name = $"{DateTime.Now.ToShortDateString()}";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < dataGridView1.Rows.Count + 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            ws.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            ws.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i - 1].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = ".xlsx";
                savefile.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                savefile.FilterIndex = 2;
                savefile.FileName = $"{DateTime.Now.ToLocalTime().ToString().Replace(":", "-").Replace(".", "-")}";

                if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    wb.SaveAs(savefile.FileName);
                    //Invoke(new AddMessageDelegate(LogAdd), new object[] { "[" + DateTime.Now.ToString() + "]" + " " + "Файл сохранен в формате Excel (.xlsx)" + Environment.NewLine });
                }
            }
            catch (Exception)
            {
                //Invoke(new AddMessageDelegate(LogAdd), new object[] { "[" + DateTime.Now.ToString() + "]" + " " + "При сохранении файла что то пошло не так." + Environment.NewLine });
            }
            finally
            {
                excel.Quit();
                wb = null;
                excel = null;
            }
        }
    }
}
