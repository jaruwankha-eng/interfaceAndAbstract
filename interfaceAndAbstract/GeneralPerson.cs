using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAndAbstract
{
    public class GeneralPerson : Person, ITrainable, ITrainer
    {
        public string Workplace { get; set; }
        public string Position { get; set; }

        public GeneralPerson(string firstName, string lastName, string phone, string email,
                             string workplace, string position)
            : base(firstName, lastName, phone, email)
        {
            Workplace = workplace;
            Position = position;
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
            Console.WriteLine("General: " + GetFullName() +
                              " | ที่ทำงาน: " + Workplace +
                              " | ตำแหน่ง: " + Position);
        }
    }
}
