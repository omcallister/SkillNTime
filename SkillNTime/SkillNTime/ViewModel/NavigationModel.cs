using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillNTime.ViewModel
{
    public class NavigationModel
    {
        public int Hours { get; }
        public int TimeSpent { get; }
        public IEnumerable<string> SkillName { get; }

        public NavigationModel(int hours, int timespent, IEnumerable<string> skillname)
        {
            Hours = hours;
            TimeSpent = timespent;
            SkillName = skillname;
        }

        public string SkillsAsString => string.Join(", ", SkillName);
    }
}
