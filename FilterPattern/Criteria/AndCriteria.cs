using FilterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Criteria
{
    public class AndCriteria : IPersonCriteria
    {
        private IPersonCriteria criteria;
        private IPersonCriteria otherCriteria;

        public AndCriteria(IPersonCriteria criteria, IPersonCriteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public IList<Person> MeetCriteria(IList<Person> persons)
        {
            return otherCriteria.MeetCriteria(criteria.MeetCriteria(persons));
        }
    }
}
