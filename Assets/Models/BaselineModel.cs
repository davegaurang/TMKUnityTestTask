using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboards.Assets
{
    public class BaselineModel
    {
        public BaselineModel( string date, decimal time, int accuracy, string words)
        {
            Date = date;
            Time = time;
            Accuracy = accuracy;
            Words = words;
        }

        public string Date { get; set; }
        public decimal Time { get; set; }
        public int Accuracy { get; set; }
        public string Words { get; set; }

    
    }

    public class PlayListModel
    {
        public PlayListModel(string title, string tag1, string tag2, string tag3)
        {
            Title = title;
            Tag1 = tag1;
            Tag2 = tag2;
            Tag3 = tag3;
        }
        public string Title { get; set; }
        public string Tag1 { get; set; }
        public string Tag2 { get; set; }
        public string Tag3 { get; set; }


    }
}
