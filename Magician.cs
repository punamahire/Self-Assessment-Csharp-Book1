using System;
using System.Collections.Generic;
using System.Linq;

namespace Orientation
{
    public class Magician : Person, ISkilled
    {
        private List<Illusion> _illusions;

        public Magician(List<Illusion> illusions)
        {
            if (illusions == null)
            {
                throw new ArgumentNullException("Illusions can't be null");
            }

            _illusions = illusions;
        }

        public override string FullName
        {
            get { return $"{FirstName} {LastName} the Great and Mysterious"; }
        }

        public List<string> GetBeginnerSkills()
        {
            List<string> results = _illusions
                .Where(il => !il.IsExpert)
                .Select(il => il.Name)
                .ToList();

            return results;
        }

        public List<string> GetExpertSkills()
        {
            List<string> results = _illusions
                .Where(il => il.IsExpert)
                .Select(il => il.Name.ToUpper())
                .ToList();

            return results;
        }

        public override string ToString()
        {
            return base.ToString() + ". Want to see an illusion?";
        }

        public void StudySkill(string skill)
        {
            if (_illusions.Any(il => il.Name == skill))
            {
                foreach (Illusion il in _illusions)
                {
                    if (il.Name == skill)
                    {
                        il.IsExpert = true;
                    }
                }
            }
            else
            {
                Illusion newlyLearned = new Illusion()
                {
                    Name = skill,
                    IsExpert = false
                };

                _illusions.Add(newlyLearned);

                Console.WriteLine(_illusions.Count);
            }

        }
    }
}