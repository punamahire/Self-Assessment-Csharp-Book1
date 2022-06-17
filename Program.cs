using System;
using System.Collections.Generic;

namespace Orientation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Magician m = new Magician(new List<Illusion>());

            List<Illusion> illusions = new List<Illusion>()
            {
                new Illusion() { Name = "Rabbit Trick", IsExpert = false },
                new Illusion() { Name = "Disappearing Trick", IsExpert = true },
                new Illusion() { Name = "Card Trick", IsExpert = false }
            };

            Magician aMagician = new Magician(illusions);
            aMagician.FirstName = "Nuttin";
            aMagician.LastName = "Upmesleve";

            ISkilled skilledMagician = aMagician;

            List<string> beginnerMag = new List<string>();

            beginnerMag = aMagician.GetBeginnerSkills();

            foreach (var mag in beginnerMag)
            {
                Console.WriteLine($"{mag}");
            }

            //aMagician.StudySkill("Sawing in Half Trick");

            List<string> expertMag = new List<string>();

            aMagician.StudySkill("Rabbit Trick");
            expertMag = aMagician.GetExpertSkills();

            foreach (var mag in expertMag)
            {
                Console.WriteLine($"{mag}");
            }

            Console.WriteLine(aMagician.ToString());
        }
    }
}
