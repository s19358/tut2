using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace tutorial2
{
     public class Student
    {

        [XmlElement(ElementName = "fname")]
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string snumber { get; set; }
    }
}
