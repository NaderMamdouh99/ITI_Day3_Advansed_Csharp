using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }


        public Employee(int _id, string _Name, int _Salary,string _Gender,int _Experience)
        {
            this.id = _id;
            this.Name = _Name;
            this.Salary = _Salary;
            this.Gender = _Gender;
            this.Experience = _Experience;

            
        }
        public override string ToString()
        {
            return $"Id = {id} : Name = {Name} : Salary = {Salary} : Gender = {Gender} : Experience = {Experience} :";
        }
    }
}
