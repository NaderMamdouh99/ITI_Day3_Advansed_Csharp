using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace Day3
{
    internal class Program
    {
            #region Delegate
            public delegate bool DelagateEmp(Employee empID);

            public static bool PromotionSalary(Employee Emp)
            {
                return Emp.Salary < 10000;
            }
            public static bool PromotionExperience(Employee Emp)
            {
                return Emp.Experience > 5;
            }
            public static List<Employee> PromotionEmployees(List<Employee> employees, DelagateEmp delagateEmp)
            {
                List<Employee> Result = new List<Employee>();
                foreach (var item in employees)
                {
                    if (delagateEmp(item))
                        Result.Add(item);
                }
                return Result;
            } 
        #endregion

        static void Main(string[] args)
        {
			#region Assignment
                //1.Create a class Employee that has the following properties:
                    //a.Id.
                    //		b.Name.
                    //		c.Salary.
                    //d.Gender.
                    //e.Experience.
                //2.Make a function Promote that return a list of promoted Employees according to PromotionCriteria Function.
                //3.PromotionCriteria is a function with the following signature
                    //Public Static bool PromotionCriteria(Employee emp)
                    //That returns whether the emp should be promoted or not.
                //4.	Create 2 Promotion Criteria:
                    //a.One if the salary is under 10000.
                    //b.One if the experience years are above 5.
                //5.	Try to use Lambda expression.

		#endregion

            #region Lab

			List<Employee> list = new List<Employee>();
            list.Add(new Employee(10, "Nader", 15000, "M", 6));
            list.Add(new Employee(11, "Nada", 5000, "F", 4));
            list.Add(new Employee(12, "Aya", 8000, "F", 3));
            list.Add(new Employee(14, "Ali", 18000, "M", 7));
            DelagateEmp Del = PromotionSalary;
            DelagateEmp Del2 = PromotionExperience;

            Console.WriteLine("a.\tOne if the salary is under 10000");
            foreach (var item in PromotionEmployees(list, Del))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("b.\tOne if the experience years are above 5.");
            foreach (var item in PromotionEmployees(list, Del2))
            {
                Console.WriteLine(item);
            }
            PromotionEmployees(list, E => E.Experience > 3); 
            #endregion
        }
    }
}