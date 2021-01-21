using FilterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Criteria
{
    public class OrCriteria : IPersonCriteria
    {
        private IPersonCriteria criteria;
        private IPersonCriteria otherCriteria;

        public OrCriteria(IPersonCriteria criteria, IPersonCriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            var firstCriteriaItems = criteria.MeetCriteria(persons);
            foreach (var person in otherCriteria.MeetCriteria(persons))
            {
                if (!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }
    }
}
