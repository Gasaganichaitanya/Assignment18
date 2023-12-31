﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    internal class Smartphone : IConnectable, IRechargeable, IDisplayable

    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }

        public Smartphone(string model)
        {
            Model = model;
        }

        public bool Connect()
        {
            if (!IsConnected)
            {
                Console.WriteLine($"Connecting to {Model}...");
                // Simulate connection process
                IsConnected = true;
                return true;
            }

            Console.WriteLine($"{Model} is already connected.");
            return false;

        }

        public void Charge(int minutes)
        {
            if (IsConnected)
            {
                Console.WriteLine($"Charging {Model} for {minutes} minutes...");
                // Simulate charging process
                BatteryLevel += minutes * 7 / 2;
            }
            else
            {
                Console.WriteLine($"{Model} is not connected. Cannot charge.");
            }

        }

        public string Display()
        {
            var x = $"Smartphone Model: {Model} \nBattery Level: {BatteryLevel}%";


            return x;
        }


    }
}