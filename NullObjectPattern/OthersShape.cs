using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    /// <summary>
    /// 实现基于Factory Pattern.SimpleFactory
    /// 
    /// 使用在需要检查空值的地方
    /// </summary>
    public class OthersShape : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Current Shape is not support.");
        }
    }
}
