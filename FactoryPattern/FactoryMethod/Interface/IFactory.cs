using FactoryPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethod
{
    /// <summary>
    /// 工厂方法模式把具体实例化的过程延伸到具体的工厂类中,解决了简单工厂模式中要新增类就得改工厂类代码的缺点,符合了开闭原则（对拓展开放，对修改封闭）。
    /// 缺点是每新增一个类型，就得新增一个对应的工厂类，增加代码量
    /// </summary>
    public interface IFactory
    {
        IShape Shape();
    }
}
