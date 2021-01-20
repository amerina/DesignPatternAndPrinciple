using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Green : IColor
    {
        public void fill()
        {
            System.Console.WriteLine("fill Green.");
        }
    }
}
