using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { firstname = "Aysenur", lastname = "Ozgur", snumber = "s19358" ,birthdate="06.08.1997",email="s19358@pjwstk.edu.pl"};
            FileStream writer = new FileStream(@"data.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Student), new XmlRootAttribute("university"));

            serializer.Serialize(writer, student);

            Console.WriteLine("Hello World!");


        }
    }
}
