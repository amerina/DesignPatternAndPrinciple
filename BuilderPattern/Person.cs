using FilterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Person
    {
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        /// <summary>
        /// ex-girlfriend or ex-boyfriend
        /// </summary>
        public List<string> ExFriend { get; set; } = new List<string>();

        public override string ToString()
        {
            return string.Format("Name:{0},Gender:{1},MaritalStatus:{2},ExFriend:{3}", Name, Gender.ToString(), MaritalStatus.ToString(), ExFriend.Count == 0 ? "My wife has no ex-boy friend." : string.Join(",", ExFriend));
        }
    }
}
