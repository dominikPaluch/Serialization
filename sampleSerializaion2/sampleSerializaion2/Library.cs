using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace sampleSerializaion2
{
    public class Library
    {
        public List<Book> ListOfBook;

        public Library()
        {
            ListOfBook = new List<Book>();
        }

        public  void Add(Book b)
        {
            ListOfBook.Add(b);
        }

        public void ShowLibrary()
        {
            foreach(var b in ListOfBook)
            {
                Console.WriteLine("autor: " + b.author + ", tytuł: " + b.title + ", ilość stron: " + b.page);
            }
        }

        public string Serializing(Library lib)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Library));
           // var lib = new Library();
            StringWriter sww = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(sww))
            {
                xsSubmit.Serialize(writer, lib);
                var xml = sww.ToString(); // Your XML

                FileStream fs1 = new FileStream("C:/Users/Dominik/Desktop/a.xt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer2 = new StreamWriter(fs1);
                writer2.Write(xml);
                writer2.Close();
                //

                return xml;
            }
        }
    }
}
