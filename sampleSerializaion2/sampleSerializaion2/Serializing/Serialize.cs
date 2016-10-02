//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;
//using System.Xml.Serialization;

//namespace sampleSerializaion2.Serializing
//{
//    public  class Serialize
//    {
//        XmlSerializer xsSubmit = new XmlSerializer(typeof(Library));
//        Library lib = new Library();
//        StringWriter sww = new StringWriter();

//         using(XmlWriter writer = XmlWriter.Create(sww))
//         {
//             xsSubmit.Serialize(writer, lib);
//             var xml = sww.ToString(); // Your XML
//        }
//    }
//}
