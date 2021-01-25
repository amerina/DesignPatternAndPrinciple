using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Interface;

namespace VisitorPattern
{
    /// <summary>
    /// ConcreteElement
    /// </summary>
    public class Student : IElement
    {
        public string Name { get; private set; }

        public Student(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 允许一个或者多个操作应用到一组对象上,解耦操作和对象本身
        /// 通过注入IVisitor接口解耦Student对象与Student对象的操作
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
