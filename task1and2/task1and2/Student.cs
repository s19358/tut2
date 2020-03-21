using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace task1and2
{
    [Serializable]
    public class Student
    {
        [XmlAttribute(AttributeName = "snumber")]
        public string snumber { get; set; }

        [XmlElement(ElementName = "fname")]
        public string firstname { get; set; }

        [XmlElement(ElementName = "lname")]
        public string lastname { get; set; }
        public string birthday { get; set; }
        public string mail { get; set; }
        public string mothersname { get; set; }
        public string fathersname { get; set; }
        [XmlElement(ElementName = "studies")]
        public Study department { get; set; }
        public Study mode { get; set; }
    
       
       
    }
}
