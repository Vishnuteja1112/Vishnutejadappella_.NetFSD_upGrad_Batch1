using System;
using System.Collections.Generic;

namespace OOPAssignments
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose Assignment");
            Console.WriteLine("1 Healthcare System");
            Console.WriteLine("2 Banking System");
            Console.WriteLine("3 E-Commerce Order System");
            Console.WriteLine("4 Vehicle System");
            Console.WriteLine("5 Education System");
            Console.WriteLine("6 Furniture System");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    HealthcareTest.Run();
                    break;

                case 2:
                    BankingTest.Run();
                    break;

                case 3:
                    OrderTest.Run();
                    break;

                case 4:
                    VehicleTest.Run();
                    break;

                case 5:
                    StudentTest.Run();
                    break;

                case 6:
                    FurnitureTest.Run();
                    break;
            }
        }
    }

    // -------------------------------------------------
    // Assignment 1 Healthcare System
    // -------------------------------------------------

    class Staff
    {
        public int StaffId;
        public string Name;
        public double BaseSalary;

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }

    class Doctor : Staff
    {
        public double ConsultationFee;

        public override double CalculateSalary()
        {
            return BaseSalary + ConsultationFee;
        }
    }

    class Nurse : Staff
    {
        public double NightShiftAllowance;

        public override double CalculateSalary()
        {
            return BaseSalary + NightShiftAllowance;
        }
    }

    class LabTechnician : Staff
    {
        public double EquipmentAllowance;

        public override double CalculateSalary()
        {
            return BaseSalary + EquipmentAllowance;
        }
    }

    class HealthcareTest
    {
        public static void Run()
        {
            Staff s1 = new Doctor { Name = "Doctor", BaseSalary = 50000, ConsultationFee = 10000 };
            Staff s2 = new Nurse { Name = "Nurse", BaseSalary = 30000, NightShiftAllowance = 5000 };
            Staff s3 = new LabTechnician { Name = "LabTech", BaseSalary = 25000, EquipmentAllowance = 3000 };

            Staff[] staffList = { s1, s2, s3 };

            foreach (Staff s in staffList)
                Console.WriteLine(s.Name + " Salary: " + s.CalculateSalary());
        }
    }

    // -------------------------------------------------
    // Assignment 2 Banking System
    // -------------------------------------------------

    class Account
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Base account interest calculation");
        }
    }

    class SavingsAccount : Account
    {
        public new void CalculateInterest()
        {
            Console.WriteLine("Savings account interest calculation");
        }
    }

    class CurrentAccount : Account
    {
        public new void CalculateInterest()
        {
            Console.WriteLine("Current account interest calculation");
        }
    }

    class BankingTest
    {
        public static void Run()
        {
            Account acc = new SavingsAccount();
            acc.CalculateInterest();
        }
    }

    // -------------------------------------------------
    // Assignment 3 Order System
    // -------------------------------------------------

    class Order
    {
        public virtual double CalculateShippingCost()
        {
            return 50;
        }
    }

    class StandardOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return 50;
        }
    }

    class ExpressOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return 100;
        }
    }

    class InternationalOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return 500;
        }
    }

    class OrderTest
    {
        public static void Run()
        {
            List<Order> orders = new List<Order>
            {
                new StandardOrder(),
                new ExpressOrder(),
                new InternationalOrder()
            };

            foreach (Order o in orders)
                Console.WriteLine("Shipping Cost: " + o.CalculateShippingCost());
        }
    }

    // -------------------------------------------------
    // Assignment 4 Vehicle System
    // -------------------------------------------------

    class Vehicle
    {
        public string VehicleNumber;
        public string Brand;

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle Started");
        }
    }

    class Car : Vehicle
    {
        public string FuelType;
    }

    sealed class ElectricCar : Car
    {
        public int BatteryCapacity;
    }

    class VehicleTest
    {
        public static void Run()
        {
            ElectricCar ec = new ElectricCar();
            ec.StartVehicle();
        }
    }

    // -------------------------------------------------
    // Assignment 5 Education System
    // -------------------------------------------------

    class Student
    {
        public int Marks;

        public virtual void CalculateGrade()
        {
            Console.WriteLine(Marks > 50 ? "Pass" : "Fail");
        }
    }

    class SchoolStudent : Student
    {
        public override void CalculateGrade()
        {
            Console.WriteLine(Marks > 40 ? "Pass" : "Fail");
        }
    }

    class CollegeStudent : Student
    {
        public override void CalculateGrade()
        {
            Console.WriteLine(Marks > 50 ? "Pass" : "Fail");
        }
    }

    class OnlineStudent : Student
    {
        public override void CalculateGrade()
        {
            Console.WriteLine(Marks > 60 ? "Pass" : "Fail");
        }
    }

    class StudentTest
    {
        public static void Run()
        {
            Student[] students =
            {
                new SchoolStudent{Marks=45},
                new CollegeStudent{Marks=55},
                new OnlineStudent{Marks=58}
            };

            foreach (Student s in students)
                s.CalculateGrade();
        }
    }

    // -------------------------------------------------
    // Assignment 6 Furniture System
    // -------------------------------------------------

    class Furniture
    {
        public int OrderId;
        public int Qty;
        public double TotalAmt;

        public virtual void GetData()
        {
            Console.WriteLine("Enter OrderId:");
            OrderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Qty:");
            Qty = int.Parse(Console.ReadLine());
        }

        public virtual void ShowData()
        {
            Console.WriteLine("OrderId: " + OrderId);
            Console.WriteLine("Qty: " + Qty);
            Console.WriteLine("TotalAmt: " + TotalAmt);
        }
    }

    class Chair : Furniture
    {
        public double Rate;

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter Chair Rate:");
            Rate = double.Parse(Console.ReadLine());
            TotalAmt = Rate * Qty;
        }
    }

    class Cot : Furniture
    {
        public double Rate;

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter Cot Rate:");
            Rate = double.Parse(Console.ReadLine());
            TotalAmt = Rate * Qty;
        }
    }

    class FurnitureTest
    {
        public static void Run()
        {
            Chair c = new Chair();
            c.GetData();
            c.ShowData();
        }
    }
}