﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        double vozrast;
        double rost;
        string Name;
        string status;

        public Class1(double vozrast, double rost, string name, string status)
        {
            this.vozrast = vozrast;
            this.rost = rost;
            Name = name;
            this.status = status;
        }
        public double ReturnVozrast()
        {
            return vozrast;
        }
        public string ReturnName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public double ReturnRost()
        {
            return rost;
        }
        public string ReturnStatus()
        {
            return status;
        }
    }
}
