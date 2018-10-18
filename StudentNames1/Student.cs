using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StudentNames
{
    class Student
    {
        public String StudentData { get; set; }

        StreamReader sr = new StreamReader(@"C:\Users\breon\source\repos\StudentNames\StudentNames\studentdata.txt");

        public string ReadData()
        {
            StudentData = sr.ReadLine();
            return StudentData;
        }
    }
}
