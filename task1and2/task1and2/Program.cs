using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace task1and2
{
    class Program
    {


        static void Main(string[] args)
        {
            StreamWriter sw = null;
            try
            {
                //string csvfilepath = args[0];
                //string destpath = args[1];
                //string dataformat = args[2];
                var logfile = @"C:\Users\aysen\Desktop\apbd\tutorials\tut2\task1and2\task1and2\log.txt";
                sw = File.AppendText(logfile);
                //sw.WriteLine("hey");

                string csvpath  = @"C:\Users\aysen\Desktop\apbd\tutorials\tut2\task1and2\task1and2\csvStudents.csv";
                List<Student> students = new List<Student>();

                List<string> csvstudents = LoadCsv(csvpath);
                for (int i = 0; i < csvstudents.Count; i++)
                {
                    string[] headers = csvstudents[i].Split(',');

                    students.Add(new Student()
                    {
                        snumber = headers[0],
                        firstname = headers[1],
                        lastname = headers[2],
                        birthday = headers[3],
                        mail = headers[4],
                        department = new Study() { department = headers[5] ,mode = headers[6] },
                        //mode = new Study() { mode = headers[6] },
                        mothersname = headers[7],
                        fathersname = headers[8]
                    });

                }

                //for (int i = 0; i < students.Count; i++)
                //{
                //    Console.WriteLine(students[i].snumber);
                //}


                FileStream writer = new FileStream(@"data.xml", FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>), new XmlRootAttribute("university"));
                serializer.Serialize(writer, students);



            }
            catch (ArgumentException )
            {
                sw.WriteLine("The path is incorrect");

            } catch (FileNotFoundException) {

                sw.WriteLine("File does not exist");
            }
            finally
            {
                sw.Close();
            }


        }
        public static List<string> LoadCsv(string sourcePath)
        {
            var lines = File.ReadAllLines(sourcePath).ToList();

            var formatedLines = new List<string>();

            foreach (var line in lines)
            {
                var formatedLine = line.TrimEnd(',');
                formatedLines.Add(formatedLine);
            }
            return formatedLines;
        }
    }
}

