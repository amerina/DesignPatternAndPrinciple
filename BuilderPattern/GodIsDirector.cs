using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// This class can be called the Director
    /// </summary>
    public class GodIsDirector
    {
        public void Construct(IPersonBuilder builder)
        {
            builder.AddName();
            builder.AddGender();
            builder.AddMaritalStatus();
            builder.AddExFriend();
        }
    }
}
