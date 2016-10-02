using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleSerializaion2
{
    public class Book
    {
        public string author, title;
        public int page;
        public float price;
        public Book()
        {

        }

        public Book(string _author, string _title, int _page, float _price)
        {
            author = _author;
            title = _title;
            page = _page;
            price = _price;
        }
    }
}
