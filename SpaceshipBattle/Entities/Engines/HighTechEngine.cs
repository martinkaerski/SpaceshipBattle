﻿using SpaceshipsBattle.Entities.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipBattle.Entities.Engines
{
    public class HighTechEngine : Engine
    {
        protected HighTechEngine(string model, int price, int weight, int power, int fuelCapacity, FuelType fuelType) : base(model, price, weight, power, fuelCapacity, fuelType)
        {
        }
    }
}
