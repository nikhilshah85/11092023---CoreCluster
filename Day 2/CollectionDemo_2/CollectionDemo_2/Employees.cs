using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo_2
{
    internal class Employees
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public bool EmpIsPermenant { get; set; }
        public string EmpCity { get; set; }

        static List<Employees> eList = new List<Employees>()
        {
            new Employees() { EmpNo=101, EmpName="Nikhil", EmpCity="Mumbai", EmpIsPermenant=true, EmpSalary=7000},
            new Employees() { EmpNo=102, EmpName="Siddhi", EmpCity="Pune", EmpIsPermenant=true, EmpSalary=7000},
            new Employees() { EmpNo=103, EmpName="Nirav", EmpCity="Mumbai", EmpIsPermenant=true, EmpSalary=7000},
            new Employees() { EmpNo=104, EmpName="Yash", EmpCity="Mumbai", EmpIsPermenant=false, EmpSalary=7000},
            new Employees() { EmpNo=105, EmpName="Kriti", EmpCity="Pune", EmpIsPermenant=true, EmpSalary=7000},
            new Employees() { EmpNo=106, EmpName="Sonam", EmpCity="Mumbai", EmpIsPermenant=false, EmpSalary=7000}
        };


        public List<Employees> GetAllEmployees()
        {
            return eList;
        }

        public int TotalEmployees()
        {
            return eList.Count;
        }

        public List<Employees> GetByCity(string cityName)
        {
            var emp = eList.FindAll(e => e.EmpCity == cityName);
            return emp;
        }

        public Employees GetEmpById(int id)
        {
            var emp = eList.Find(e => e.EmpNo == id);
            if (emp == null)
            {
                throw new Exception("Employee Not Found");
            }
            return emp;

        }

        public double GetTotalSalaryPaid()
        {
            var total = eList.Sum(e => e.EmpSalary);
            return total;
        }

        public string AddNewEmployee(Employees newEmp)
        {
            //perform some validations, eg. salary cannot be negative, or name cannot be less than 3 characters etc..

            if (newEmp.EmpSalary < 5000)
            {
                throw new Exception("Employee Salary should be minimum 5000");
            }
            eList.Add(newEmp);
            return "Employee Added Successfully";
        }

        public string EditEmployee(Employees changes)
        {
            var emp = eList.Find(e => e.EmpNo == changes.EmpNo);
            if (emp == null)
            {
                throw new Exception("Employe with employee number : " + changes.EmpNo + " Not found ");
            }

            emp.EmpName = changes.EmpName;
            emp.EmpSalary = changes.EmpSalary;
            emp.EmpIsPermenant = changes.EmpIsPermenant;
            emp.EmpCity = changes.EmpCity;
            return "Employee Details changed successfully";
        }

        public string DeleteEmployee(int eno)
        {
            var emp = eList.Find(e => e.EmpNo == eno);
            if (emp == null)
            {
                throw new Exception("Employee not found, thus not deleted");
            }
            eList.Remove(emp);
            return "Employee Delete successfully";
        }

        public void ClearAndHold()
        {
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
        }

    }
}
