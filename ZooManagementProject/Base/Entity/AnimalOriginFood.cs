﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagementProject.Base.Enum;

namespace ZooManagementProject.Base.Entity
{
    public abstract class AnimalOriginFood : Food
    {
        public readonly FoodType foodType;

        public AnimalOriginFood()
        {
            foodType = FoodType.AnimalOrigin;
        }
    }
}
