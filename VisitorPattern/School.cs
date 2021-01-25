using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Interface;

namespace VisitorPattern
{
    /// <summary>
    /// ObjectStructure 
    /// </summary>
    public class School
    {
        private static List<IElement> Elements;

        public School()
        {
            Elements = new List<IElement>
            {
                new Student("Amerina"),
                new Student("Amerina's girl friend")
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        public void PerformOperation(IVisitor visitor)
        {
            Elements.ForEach(student =>
            {
                student.Accept(visitor);
            });
    
        }
    }
}
