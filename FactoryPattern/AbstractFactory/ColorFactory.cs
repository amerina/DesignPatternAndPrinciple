using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.SimpleFactory;

namespace FactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(ColorTypeEnum color)
        {
            switch (color)
            {
                case ColorTypeEnum.RED:
                    return new Red();
                case ColorTypeEnum.GREEN:
                    return new Green();
                default:
                    return null;
            }
        }

        public override IShape GetShape(ShapeTypeEnum shape)
        {
            throw new NotImplementedException();
        }
    }
}
