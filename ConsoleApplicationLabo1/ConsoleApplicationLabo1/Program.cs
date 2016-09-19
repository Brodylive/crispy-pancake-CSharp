using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil e1 = new Pupil("Eva", 12);
            Activity gym = new Activity("Gym", true);
            Activity science = new Activity("Science", false);
            Activity informatique = new Activity("Informatique", false);
            Activity nature = new Activity("Nature", true);

            e1.AddActivity(gym);
            e1.AddActivity(science);

            e1.AddEvaluation(gym.Title, 'S');

            System.Console.Write(e1);
            System.Console.Read();
        }
    }
}
