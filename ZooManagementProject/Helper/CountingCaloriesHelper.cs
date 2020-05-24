using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagementProject.Base.Entity;

namespace ZooManagementProject.Helper
{
    public class CountingCaloriesHelper
    {
        public double GetCalories(Animal animal)
        {
            try
            {
                TimeSpan timeSpan = DateTime.Now - animal.DayOfBith;
                
                return Math.Pow(animal.Weight, 0.75) * 70 + timeSpan.TotalDays * 0.35;
            }
            catch(Exception ex)
            {
                return 100;
            }
        }
    }
}
