using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAndAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrainingSystem system = new TrainingSystem();
            int choice;

            do
            {
                Console.WriteLine("\n===== ระบบลงทะเบียนอบรม =====");
                Console.WriteLine("1. เพิ่มนักศึกษา");
                Console.WriteLine("2. เพิ่มอาจารย์");
                Console.WriteLine("3. เพิ่มบุคคลทั่วไป");
                Console.WriteLine("4. แสดงรายชื่อผู้เข้าอบรม");
                Console.WriteLine("5. แสดงรายชื่อวิทยากร");
                Console.WriteLine("0. ออกจากโปรแกรม");
                Console.Write("เลือกเมนู: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent(system);
                        break;

                    case 2:
                        AddTeacher(system);
                        break;

                    case 3:
                        AddGeneralPerson(system);
                        break;

                    case 4:
                        system.ShowParticipants();
                        break;

                    case 5:
                        system.ShowTrainers();
                        break;
                }

            } while (choice != 0);
        }

        static void AddStudent(TrainingSystem system)
        {
            Console.Write("ชื่อ: ");
            string firstName = Console.ReadLine();

            Console.Write("นามสกุล: ");
            string lastName = Console.ReadLine();

            Console.Write("เบอร์โทร: ");
            string phone = Console.ReadLine();

            Console.Write("อีเมล: ");
            string email = Console.ReadLine();

            Console.Write("รหัสนักศึกษา: ");
            string studentId = Console.ReadLine();

            Console.Write("สาขา: ");
            string major = Console.ReadLine();

            Student s = new Student(firstName, lastName, phone, email, studentId, major);

            system.AddParticipant(s);
        }

        static void AddTeacher(TrainingSystem system)
        {
            Console.Write("ชื่อ: ");
            string firstName = Console.ReadLine();

            Console.Write("นามสกุล: ");
            string lastName = Console.ReadLine();

            Console.Write("เบอร์โทร: ");
            string phone = Console.ReadLine();

            Console.Write("อีเมล: ");
            string email = Console.ReadLine();

            Console.Write("สาขา: ");
            string major = Console.ReadLine();

            Console.Write("ตำแหน่งทางวิชาการ (อาจารย์/ผศ./รศ./ศ): ");
            string position = Console.ReadLine();

            Teacher t = new Teacher(firstName, lastName, phone, email, major, position);

            system.AddParticipant(t);

            Console.Write("ต้องการเป็นวิทยากรหรือไม่? (y/n): ");
            string isTrainer = Console.ReadLine();

            if (isTrainer.ToLower() == "y")
            {
                system.AddTrainer(t);
            }
        }

        static void AddGeneralPerson(TrainingSystem system)
        {
            Console.Write("ชื่อ: ");
            string firstName = Console.ReadLine();

            Console.Write("นามสกุล: ");
            string lastName = Console.ReadLine();

            Console.Write("เบอร์โทร: ");
            string phone = Console.ReadLine();

            Console.Write("อีเมล: ");
            string email = Console.ReadLine();

            Console.Write("สถานที่ทำงาน: ");
            string workplace = Console.ReadLine();

            Console.Write("ตำแหน่ง: ");
            string position = Console.ReadLine();

            GeneralPerson g = new GeneralPerson(firstName, lastName, phone, email, workplace, position);

            system.AddParticipant(g);

            Console.Write("ต้องการเป็นวิทยากรหรือไม่? (y/n): ");
            string isTrainer = Console.ReadLine();

            if (isTrainer.ToLower() == "y")
            {
                system.AddTrainer(g);
            }
        }
    }
}


