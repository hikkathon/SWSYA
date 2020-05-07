using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSYA
{
    class Scraper
    {
        private ObservableCollection<EntryModel> _entries = new ObservableCollection<EntryModel>();

        public ObservableCollection<EntryModel> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }

        public void GetContent()
        {
            var html = @"http://html-agility-pack.net/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
        }
    }
}
