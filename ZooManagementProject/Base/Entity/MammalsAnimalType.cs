using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagementProject.Base.Enum;

namespace ZooManagementProject.Base.Entity
{
    public abstract class MammalsAnimalType : Animal
    {
        private AnimalType animalType;

        public MammalsAnimalType()
        {
            animalType = AnimalType.Mammals;
        }
    }
}
