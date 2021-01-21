using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 抽象建造者接口
    /// </summary>
    public interface IPersonBuilder
    {
        void AddName();

        void AddGender();

        void AddMaritalStatus();

        void AddExFriend();

        Person GetPerson();
    }
}
