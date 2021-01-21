using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class AmerinaWifeBuilder : IPersonBuilder
    {
        /// <summary>
        /// for god, people is a product.
        /// </summary>
        private Person product = new Person();
        public void AddExFriend()
        {
            product.ExFriend = new List<string>();
        }

        public void AddGender()
        {
            product.Gender = FilterPattern.GenderType.Female;
        }

        public void AddMaritalStatus()
        {
            product.MaritalStatus = FilterPattern.MaritalStatus.Married;
        }

        /// <summary>
        /// Figure gallo from Tom and Jerry
        /// </summary>
        public void AddName()
        {
            product.Name = "Figure gallo";
        }

        public Person GetPerson()
        {
            return product;
        }
    }
}
