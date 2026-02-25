using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAndAbstract
{
    public class TrainingSystem
    {
        private List<Person> Participants = new List<Person>();
        private List<Person> Trainers = new List<Person>();

        public void AddParticipant(Person p)
        {
            Participants.Add(p);
        }

        public void AddTrainer(Person p)
        {
            Trainers.Add(p);
        }

        public void ShowParticipants()
        {
            Console.WriteLine("\nรายชื่อผู้เข้าอบรม");
            foreach (var p in Participants)
            {
                p.DisplayInfo();
            }
        }

        public void ShowTrainers()
        {
            Console.WriteLine("\nรายชื่อวิทยากร");
            foreach (var t in Trainers)
            {
                t.DisplayInfo();
            }
        }
    }
}
