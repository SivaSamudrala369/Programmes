using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inheritance_in_Class
{
    abstract class Employee_03
    {
        int EmpId;
        string Ename;
        protected double Salary;
        public void AcceptData()
        {
            Console.Write("Enter the Employee ID = ");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Employee Name = ");
            this.Ename = Console.ReadLine();
        }
        public abstract void CalculateSal();
        public override string ToString()
        {
            string output = "The Employee Id = " + this.EmpId + "The Employee Name is = " + this.Ename;
        return output;
        }
    }
    class FullTimeEmployee_01 : Employee_03
    {
        double Basic, DA, HRA;
        public void AcceptBasicData()
        {
            Console.Write("Enter the Basic Salary = ");
            this.Basic = Convert.ToDouble(Console.ReadLine());
        }
        public override void CalculateSal()
        {
            this.DA = 0.3 * this.Basic;
            this.HRA = 0.2 * this.Basic;
            base.Salary = this.Basic + this.DA + this.HRA;
        }
        public override string ToString()
        {
            string output = base.ToString() + "\nEmployee Basic salary is = " + this.Basic + "\nThe Employee DA is = "
            + this.DA + "\nThe Employee HRA is = " + this.HRA + "\nThe Employee Gross Salary is = " + base.Salary;
            return output;
        }
    }
    class PartTimeEmployee : Employee_03
    {
        double NumberDay, HourRate;
        public void AcceptSalData()
        {
            Console.Write("Enter the Number of Days employment = ");
            this.NumberDay = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Hour rate for employment = ");
            this.HourRate = Convert.ToDouble(Console.ReadLine());
        }
        public override void CalculateSal()
        {
            base.Salary = this.NumberDay * this.HourRate * 8;
        }
        public override string ToString()
        {
            string output = base.ToString() + "\nThe Employee Worked for number of Hours is = " + this.HourRate +
            "\nThe Employee worked number of Days is = " + this.NumberDay + "\nThe Employee Gross Salary is = " +
            base.Salary;
            return output;
        }
    }

class Example_05
    {
        static void Main()
        {
            FullTimeEmployee_01 FE1 = new FullTimeEmployee_01();
            Console.WriteLine("Full time Employee Information");
            Console.WriteLine("------------------------------");
            FE1.AcceptData();
            FE1.AcceptBasicData();
            FE1.CalculateSal();
            Console.WriteLine("\nDetails of the Full time Employee");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(FE1);
            Console.WriteLine("------------------------------------------");
            PartTimeEmployee PE1 = new PartTimeEmployee();
            Console.WriteLine("Part time Employee Information");
            Console.WriteLine("------------------------------");
            PE1.AcceptData();
            PE1.AcceptSalData();
            PE1.CalculateSal();
            Console.WriteLine("\nDetails of the Part time Employee");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(PE1);
            Console.ReadKey();
        }
    }
}
