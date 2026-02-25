using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAndAbstract
{
    public class Teacher : Person, ITrainable, ITrainer
    {
        public string Major { get; set; }
        public string AcademicPosition { get; set; }

        public Teacher(string firstName, string lastName, string phone, string email,
                       string major, string academicPosition)
            : base(firstName, lastName, phone, email)
        {
            Major = major;
            AcademicPosition = academicPosition;
        }

        public void RegisterTraining()
        {
            Console.WriteLine(GetFullName() + " ลงทะเบียนอบรมแล้ว");
        }

        public void ConductTraining()
        {
            Console.WriteLine(GetFullName() + " กำลังอบรม");
        }

        public void ApproveResult()
        {
            Console.WriteLine(GetFullName() + " อนุมัติผลการอบรมแล้ว");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Teacher: " + GetFullName() +
                              " | ตำแหน่ง: " + AcademicPosition +
                              " | สาขา: " + Major);
        }
    }
}
