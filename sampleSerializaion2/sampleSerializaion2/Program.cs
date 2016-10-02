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
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Jan Kochanowski", "Urszulka" , 123, 34 );
            Book b2 = new Book("Adam Mickiewicz", "Pan Tadeusz", 439, 44);

            Library library = new Library();

            library.Add(b1);
            library.Add(b2);

            library.ShowLibrary();
            Console.WriteLine(library.Serializing(library));
            Console.ReadKey();

        }

        
    }

}
