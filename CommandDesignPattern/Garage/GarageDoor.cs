﻿using DesignPatterns.CommandDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door Open!");
        }
        public void Down()
        {
            Console.WriteLine("Garage Door Close!");
        }
        public void Stop()
        {
            Console.WriteLine("Garage Door Stop!");
        }
        public void LightOn()
        {
            Console.WriteLine("Garage Light Open!");
        }
        public void LightOff()
        {
            Console.WriteLine("Garage Light Open!");
        }
    }
}
