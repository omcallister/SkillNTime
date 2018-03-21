using SkillNTime.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillNTime
{
    public class MainPageData
    {
        public List<NavigationModel> Skills { get; set; }

        public MainPageData()
        {
            Skills = new List<NavigationModel>();

            for (int hours = 1; hours <= 4; hours++)
            {
                Skills.Add(new NavigationModel(
                    hours, 4, new string[] { "running" }));
                Skills.Add(new NavigationModel(
                    hours, 9, new string[] { "Violin", "coding" }));
            }
        }
    }
}
