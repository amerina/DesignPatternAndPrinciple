using FilterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Criteria
{
    public class CriteriaSingle : IPersonCriteria
    {
        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            return persons.Where(person => person.MaritalStatus == MaritalStatus.Single).ToList();
        }
    }
}
