using CollectionDemo_2;




bool continueOperation = true;
Employees empObj = new Employees();
Console.WriteLine("!! ~~~~~~~~~~~~~ Welcome to Employee Management ~~~~~~~~~~~~~~~~~~~ !!");


while (continueOperation)
{
    #region Menu Options
    Console.WriteLine("1. Employee List");
    Console.WriteLine("2. Find Employee By ID");
    Console.WriteLine("3. Total Employee List");
    Console.WriteLine("4. Total  Salary");
    Console.WriteLine("5. Employee List By City");
    Console.WriteLine("6. Add Employee ");
    Console.WriteLine("7. Update Employee Details");
    Console.WriteLine("8. Delete Employee");
    Console.WriteLine("9. Exit");
    #endregion

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        #region Case 1 :All Employee list
        case 1:
            var eList = empObj.GetAllEmployees();
            foreach (var item in eList)
            {
                Console.WriteLine("Employee No " + item.EmpNo);
                Console.WriteLine("Employee Name " + item.EmpName);
                Console.WriteLine("Employee City " + item.EmpCity);
                Console.WriteLine("Employee Salary " + item.EmpSalary);
                Console.WriteLine("Employee Is Permenant " + item.EmpIsPermenant);
                Console.WriteLine("______________________________________________________________");
            }

            empObj.ClearAndHold();
            break;
        #endregion

        #region Case 2 :Find By Id
        case 2:
            Console.WriteLine("Enter Employee Number");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                var item = empObj.GetEmpById(id);
                Console.WriteLine("Employee No " + item.EmpNo);
                Console.WriteLine("Employee Name " + item.EmpName);
                Console.WriteLine("Employee City " + item.EmpCity);
                Console.WriteLine("Employee Salary " + item.EmpSalary);
                Console.WriteLine("Employee Is Permenant " + item.EmpIsPermenant);
                Console.WriteLine("______________________________________________________________");
            }
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
            }
            empObj.ClearAndHold();
            break;
        #endregion

        #region Case 3 :Total Employee
        case 3:
            int total = empObj.TotalEmployees();
            Console.WriteLine("Total Employees are  " + total);
            empObj.ClearAndHold();
            break;
        #endregion

        #region Case 4 :Total Employee Salary
        case 4:
            double totalSalary = empObj.GetTotalSalaryPaid();
            Console.WriteLine("Total Salary we pay " + totalSalary);
            empObj.ClearAndHold();
            break;
        #endregion

        #region Case 5 :All Employee list By City
        case 5:
            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine();
             eList = empObj.GetByCity(city);
            foreach (var item in eList)
            {
                Console.WriteLine("Employee No " + item.EmpNo);
                Console.WriteLine("Employee Name " + item.EmpName);
                Console.WriteLine("Employee City " + item.EmpCity);
                Console.WriteLine("Employee Salary " + item.EmpSalary);
                Console.WriteLine("Employee Is Permenant " + item.EmpIsPermenant);
                Console.WriteLine("______________________________________________________________");
            }
            empObj.ClearAndHold();
            break;
        #endregion

        #region Case 6 :Add new Employee
        case 6:
            Employees newEmp = new Employees();
            Console.WriteLine("Enter Employee Number");
            newEmp.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            newEmp.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee City");
            newEmp.EmpCity = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            newEmp.EmpSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Employee isPermenat");
            newEmp.EmpIsPermenant = Convert.ToBoolean(Console.ReadLine());

            try
            {
                string add = empObj.AddNewEmployee(newEmp);
                Console.WriteLine(add);
            }
            catch (Exception es)
            {

                Console.Write(es.Message);
            }
            empObj.ClearAndHold();
            break;
        #endregion

        #region Case 7 :Edit Employee 
        case 7:

            Employees editEmpObj = new Employees();
            Console.WriteLine("Enter Employee Number");
            editEmpObj.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            editEmpObj.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee City");
            editEmpObj.EmpCity = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            editEmpObj.EmpSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Employee isPermenat");
            editEmpObj.EmpIsPermenant = Convert.ToBoolean(Console.ReadLine());

            try
            {
                string edit = empObj.EditEmployee(editEmpObj);
                Console.WriteLine(edit);
                    
            }
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
            }
            empObj.ClearAndHold();

            break;
        #endregion

        #region Case 8 :Delete Employee
        case 8:
            Console.WriteLine("Enter Employee Number to be deleted");
            id = Convert.ToInt32(Console.ReadLine());
            try
            {
                var item = empObj.DeleteEmployee(id);                
                Console.WriteLine(item);
            }
            catch (Exception es)
            {
                Console.WriteLine(es.Message);
            }
            empObj.ClearAndHold();
            break;
        #endregion

        #region Case 9 :Exit and Thank you 
        case 9:
            continueOperation = false;
            Console.WriteLine("Thank you for useing Employee management app");
            empObj.ClearAndHold();
            break;
        #endregion

        #region Default - for wrong option
        default:
            Console.WriteLine("Please enter only between 1 and 9 ");
            empObj.ClearAndHold()
            break;
            #endregion
    }



}










