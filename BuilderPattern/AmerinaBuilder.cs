using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class AmerinaBuilder : IPersonBuilder
    {
        /// <summary>
        /// for god, people is a product.
        /// </summary>
        private Person product = new Person();
        public void AddExFriend()
        {
            product.ExFriend.AddRange(new List<string>
            {
                "Scarlett Johansson",
                "Elizabeth Olsen",
                "Irina Kaptelova",
                "",
                ""
            });
        }

        public void AddGender()
        {
            product.Gender = FilterPattern.GenderType.Male;
        }

        public void AddMaritalStatus()
        {
            product.MaritalStatus = FilterPattern.MaritalStatus.Married;
        }

        public void AddName()
        {
            product.Name = "Amerina";
        }

        public Person GetPerson()
        {
            return product;
        }
    }
}
