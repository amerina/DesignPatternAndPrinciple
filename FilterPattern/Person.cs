using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    public class Person
    {
        public string Name { get; private set; }
        public GenderType Gender { get; private set; }
        public MaritalStatus MaritalStatus { get; private set; }

        public Person(string name, GenderType gender, MaritalStatus maritalStatus)
        {
            Name = name;
            Gender = gender;
            MaritalStatus = maritalStatus;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetGender(GenderType gender)
        {
            Gender = gender;
        }

        public string GetGender(GenderType gender)
        {
            return "Gender Type is " + gender.ToString();
        }

        public void SetMaritalStatus(MaritalStatus maritalStatus)
        {
            MaritalStatus = maritalStatus;
        }

        public override string ToString()
        {
            return "Person Name : " + this.Name + ", Gender : " + this.GetGender(this.Gender)+ ", Marital Status : " + this.MaritalStatus.ToString();
        }
    }
}
