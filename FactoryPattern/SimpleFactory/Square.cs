﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.SimpleFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class Square : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Square draw.");
        }
    }
}
