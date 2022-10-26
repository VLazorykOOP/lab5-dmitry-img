﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp.Task1
{
    class Car : Transport
    {
        private int _doorsCount;

        public Car(int doorsCount, double maxVelocity, int seatsCount) : base(maxVelocity, seatsCount)
        {
            Console.WriteLine("public Car(int doorsCount, double maxVelocity, int seatsCount) : base(maxVelocity, seatsCount)");
            _doorsCount = doorsCount;
        }
        public Car(double maxVelocity, int seatsCount) : this(0,maxVelocity, seatsCount)
        {
            Console.WriteLine("public Car(double maxVelocity, int seatsCount) : this(0,maxVelocity, seatsCount)");
        }
        public Car() : this(0,0)
        {
            Console.WriteLine("public Car() : this(0,0)");
        }
        
        public override void Show()
        {
            Console.WriteLine("Car:");
            base.Show();
            Console.WriteLine("Doors count: " + _doorsCount);
        }
        ~Car()
        {
            Console.WriteLine("~Car()");
        }
    }
}
