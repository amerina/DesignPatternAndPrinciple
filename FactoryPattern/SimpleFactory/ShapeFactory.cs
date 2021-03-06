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
    public class ShapeFactory
    {
        public IShape GetShape(ShapeTypeEnum shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypeEnum.CIRCLE:
                    return new Circle();
                case ShapeTypeEnum.RECTANGLE:
                    return new Rectangle();
                case ShapeTypeEnum.SQUARE:
                    return new Square();
                case ShapeTypeEnum.UnKnown:
                default:
                    return null;
            }

        }


    }
}
