using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern.Interface
{
    public interface IPersonCriteria
    {
         IList<Person> MeetCriteria(IList<Person> persons);
    }
}
