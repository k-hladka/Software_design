﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Console.Classes.PrintData
{
    public class ConsolePrint : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
