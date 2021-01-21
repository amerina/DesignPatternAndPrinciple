using System;

namespace BuilderPattern
{
    /// <summary>
    /// BuilderPattern 关键有三个类:
    /// 1.建造者接口IPersonBuilder
    /// 2.具体的建造者AmerinaBuilder
    /// 3.指挥者GodIsDirector
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GodIsDirector director = new GodIsDirector();

            IPersonBuilder amerinaBuilder = new AmerinaBuilder();
            director.Construct(amerinaBuilder);

            var amerina = amerinaBuilder.GetPerson();
            Console.WriteLine(amerina.ToString());

            IPersonBuilder amerinaWifeBuilder = new AmerinaWifeBuilder();
            director.Construct(amerinaWifeBuilder);

            var amerinaWife = amerinaWifeBuilder.GetPerson();
            Console.WriteLine(amerinaWife.ToString());

        }
    }
}
