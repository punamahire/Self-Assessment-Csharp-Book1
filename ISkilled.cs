using System.Collections.Generic;

namespace Orientation
{
    public interface ISkilled
    {
        List<string> GetExpertSkills();
        List<string> GetBeginnerSkills();
        void StudySkill(string skill);
    }
}