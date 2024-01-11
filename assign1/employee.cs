using System;
using Microsoft.Win32.SafeHandles;

namespace emp{

    abstract class Employee{
        int empId;
        string empName;
        float salary;
        DateTime doj;

        public int Eid{
            get{return empId;}
            set{empId = value;}
        }

        public string Ename{
            get{return empName;}
            set{empName = value;}
        }

        public float Salary{
            get{return salary;}
            set{salary = value;}
        }

        public DateTime DOJ{
            get{return doj;}
            set{doj = value;}
        }
        public void AcceptDetails(){
            Console.WriteLine("Enter the employee id: ");
            Eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee name: ");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter the date of joining: ");
            DOJ = Convert.ToDateTime(Console.ReadLine());
        }

        public void DisplayDetails(){
            Console.WriteLine($"Employee id is: {Eid}");
            Console.WriteLine($"Employee name is: {Ename}");
            Console.WriteLine("Employee 's date of joining is: {0}", DOJ.ToShortDateString());
        }

        public abstract void CalculateSalary();
    }

    class Permanent: Employee{

        public int BasicPay{get;set;}
        public int HRA{get;set;}
        public int DA{get; set;}
        public int PF{get;set;}

        public void getDetails(){
            AcceptDetails();
            Console.WriteLine("Enter BasicPay: ");
            BasicPay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter HRA: ");
            HRA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DA: ");
            DA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PF: ");
            PF = Convert.ToInt32(Console.ReadLine());
        }

        public override void CalculateSalary(){
            Salary = float.Parse((BasicPay + HRA + DA - PF).ToString());
        }
        public void showDetails(){
            Console.WriteLine("-------------------");
            DisplayDetails();
            Console.WriteLine($"BasicPay is: {BasicPay}");
            Console.WriteLine($"HRA is: {HRA}");
            Console.WriteLine($"DA is: {DA}");
            Console.WriteLine($"PF is: {PF}");
            CalculateSalary();
            Console.WriteLine($"Net employee salary is: {Salary}");
            Console.WriteLine("-------------------");
        }

    }

    class Trainee: Employee{
        public float Bonus{get;set;}
        public string ProjectName{get;set;}

        public void getTraineeDetails(){
            AcceptDetails();
            Console.WriteLine("Enter trainee 's salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter projectName of trainee: ");
            ProjectName = Console.ReadLine();
        }

        public void showTraineeDetails(){
            Console.WriteLine("-------------------");
            DisplayDetails();
            CalculateSalary();
            Console.WriteLine($"Trainee 's salary is: {Salary}");
            Console.WriteLine("-------------------");
        }

        public override void CalculateSalary(){
            if(ProjectName=="Banking"){
                Bonus = float.Parse((Salary*0.05).ToString());
                Salary = float.Parse((Salary+Bonus).ToString());
            }
            else if(ProjectName == "Insurance"){
                Bonus = float.Parse((Salary*0.05).ToString());
                Salary = float.Parse((Salary+Bonus).ToString());
            }
        }
    }


}