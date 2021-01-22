using FilterPattern;
using PrototypePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Person : IPrototype
    {
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        public ExFriend ExFriend { get; set; } = new ExFriend();

        /// <summary>
        /// Creates a shallow copy of the current System.Object.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Creates a deep copy of the current System.Object.
        /// </summary>
        public object DeepClone()
        {
            var person = (Person)this.MemberwiseClone();
            person.ExFriend = new ExFriend();
            person.ExFriend.Name = this.ExFriend.Name;
            return person;
        }

        public override string ToString()
        {
            return string.Format("Name:{0},Gender:{1},MaritalStatus:{2},ExFriend:{3}", Name, Gender.ToString(), MaritalStatus.ToString(), ExFriend.Name);
        }
    }

    public class ExFriend
    {
        public string Name { get; set; }

    }

}
