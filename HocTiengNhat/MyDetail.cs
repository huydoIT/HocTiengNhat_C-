using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengNhat
{
    class MyDetail
    {
        public MyDetail()
        {
        }

        public MyDetail(string _hira, string _kanji, string _mean)
        {
            hira = _hira;
            kanji = _kanji;
            mean = _mean;
        }

        public string hira { get; set; }

        public string kanji { get; set; }

        public string mean { get; set; }

    }
}
