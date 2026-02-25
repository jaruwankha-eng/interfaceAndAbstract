using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAndAbstract
{
    public class Student : Person, ITrainable
    {
        public string StudentId { get; set; }
        public string Major { get; set; }

        public Student(string firstName, string lastName, string phone, string email,
                       string studentId, string major)
            : base(firstName, lastName, phone, email)
        {
            StudentId = studentId;
            Major = major;
        }

        public void RegisterTraining()
        {
            Console.WriteLine(GetFullName() + " ลงทะเบียนอบรมแล้ว");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Student: " + GetFullName() +
                              " | รหัส: " + StudentId +
                              " | สาขา: " + Major);
        }
    }
}
