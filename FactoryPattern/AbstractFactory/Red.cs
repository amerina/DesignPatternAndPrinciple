using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// 具体产品
    /// 实现了抽象产品角色多定义的接口，由具体工厂来创建，它同具体工厂之间是多对一的关系
    /// </summary>
    public class Red : IColor
    {
        public void fill()
        {
            System.Console.WriteLine("fill Red.");
        }
    }
}
