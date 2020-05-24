using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagementProject.Base.Enum;

namespace ZooManagementProject.Base.Entity
{
    public abstract class BirdsAnimalType : Animal
    {
        public AnimalType animalType;

        public BirdsAnimalType()
        {
            animalType = AnimalType.Bird;
        }
    }
}
