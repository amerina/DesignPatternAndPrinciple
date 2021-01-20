using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// 抽象产品或者接口
    /// 定了产品的规范，描述了产品的主要特性和功能，抽象工厂模式有多个抽象产品
    /// </summary>
    public interface IColor
    {
        void fill();
    }
}
