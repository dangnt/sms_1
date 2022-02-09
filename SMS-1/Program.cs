using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UndergraduateStudent[]  uStudents = new UndergraduateStudent[10];

            uStudents[0] = new UndergraduateStudent("GCS2022-001", "Nguyen An", "CS");
            uStudents[1] = new UndergraduateStudent();

            uStudents[1].ID = "GCS2022-002";
            uStudents[1].Name = "Tran Binh";
            uStudents[1].Major = "CS";

            uStudents[0].printUndergraduateStudent();
            uStudents[1].printUndergraduateStudent();
        }
    }
}
