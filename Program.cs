using System;

namespace HealthcareAssignments
{

    // Assignment 1
    class Patient
    {
        public int PatientId;
        public string? PatientName;
        public int Age;
        public string? Disease;

        public void Display()
        {
            Console.WriteLine("Patient Id: " + PatientId);
            Console.WriteLine("Patient Name: " + PatientName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
        }
    }

    // Assignment 2
    class Doctor
    {
        public int DoctorId;
        public string? DoctorName;
        public string? Specialization;
        public double ConsultationFee;
    }

    // Assignment 3
    class Hospital
    {
        public static string? HospitalName;
        public static string? HospitalAddress;

        public string? PatientName;

        public void Display()
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Address: " + HospitalAddress);
            Console.WriteLine("Patient: " + PatientName);
        }
    }

    // Assignment 4
    class Appointment
    {
        public int AppointmentId;
        public string? PatientName;
        public string? DoctorName;
        public DateTime AppointmentDate;

        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Today;
        }
    }

    // Assignment 5
    class MedicalTest
    {
        public int TestId;
        public string? TestName;
        public double TestCost;

        public MedicalTest(int id, string name, double cost)
        {
            TestId = id;
            TestName = name;
            TestCost = cost;
        }
    }

    // Assignment 6
    class Billing
    {
        public string? PatientName;
        public double ConsultationFee;
        public double TestCharges;

        public void CalculateTotalBill()
        {
            double total = ConsultationFee + TestCharges;

            Console.WriteLine("Patient Name: " + PatientName);
            Console.WriteLine("Total Bill: " + total);
        }
    }

    // Assignment 7
    class Nurse
    {
        public int NurseId { get; set; }
        public string? NurseName { get; set; }
        public string? Department { get; set; }
    }

    // Assignment 8
    class PatientRecord
    {
        public int PatientId;
        public string? PatientName;
        public int Age;
        public string? Disease;

        public static string? HospitalName;

        public PatientRecord(int id, string name, int age, string disease)
        {
            PatientId = id;
            PatientName = name;
            Age = age;
            Disease = disease;
        }

        public void Display()
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Patient Id: " + PatientId);
            Console.WriteLine("Name: " + PatientName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Healthcare OOP Assignments");
            Console.WriteLine("1. Patient");
            Console.WriteLine("2. Doctor");
            Console.WriteLine("3. Hospital");
            Console.WriteLine("4. Appointment");
            Console.WriteLine("5. Medical Test");
            Console.WriteLine("6. Billing");
            Console.WriteLine("7. Nurse");
            Console.WriteLine("8. Patient Record");

            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Patient p = new Patient();
                    p.PatientId = 101;
                    p.PatientName = "Ravi Kumar";
                    p.Age = 45;
                    p.Disease = "Diabetes";

                    p.Display();

                    break;

                case 2:

                    Doctor d1 = new Doctor();
                    Doctor d2 = new Doctor();

                    d1.DoctorId = 1;
                    d1.DoctorName = "Dr Sharma";
                    d1.Specialization = "Cardiologist";
                    d1.ConsultationFee = 500;

                    d2.DoctorId = 2;
                    d2.DoctorName = "Dr Mehta";
                    d2.Specialization = "Neurologist";
                    d2.ConsultationFee = 700;

                    Console.WriteLine("Doctor 1: " + d1.DoctorName + " " + d1.Specialization);
                    Console.WriteLine("Doctor 2: " + d2.DoctorName + " " + d2.Specialization);

                    break;

                case 3:

                    Hospital.HospitalName = "Apollo Hospital";
                    Hospital.HospitalAddress = "Hyderabad";

                    Hospital h1 = new Hospital();
                    Hospital h2 = new Hospital();
                    Hospital h3 = new Hospital();

                    h1.PatientName = "Ravi";
                    h2.PatientName = "Suresh";
                    h3.PatientName = "Mahesh";

                    h1.Display();
                    h2.Display();
                    h3.Display();

                    break;

                case 4:

                    Appointment a = new Appointment();
                    a.AppointmentId = 201;
                    a.PatientName = "Ramesh";

                    Console.WriteLine("Appointment Id: " + a.AppointmentId);
                    Console.WriteLine("Patient Name: " + a.PatientName);
                    Console.WriteLine("Doctor: " + a.DoctorName);
                    Console.WriteLine("Date: " + a.AppointmentDate);

                    break;

                case 5:

                    MedicalTest t1 = new MedicalTest(1, "Blood Test", 500);
                    MedicalTest t2 = new MedicalTest(2, "X-Ray", 800);

                    Console.WriteLine("Test1: " + t1.TestName + " Cost: " + t1.TestCost);
                    Console.WriteLine("Test2: " + t2.TestName + " Cost: " + t2.TestCost);

                    break;

                case 6:

                    Billing b = new Billing();
                    b.PatientName = "Ramesh";
                    b.ConsultationFee = 1000;
                    b.TestCharges = 500;

                    b.CalculateTotalBill();

                    break;

                case 7:

                    Nurse n = new Nurse
                    {
                        NurseId = 1,
                        NurseName = "Anita",
                        Department = "ICU"
                    };

                    Console.WriteLine("Nurse Id: " + n.NurseId);
                    Console.WriteLine("Nurse Name: " + n.NurseName);
                    Console.WriteLine("Department: " + n.Department);

                    break;

                case 8:

                    PatientRecord.HospitalName = "Apollo Hospital";

                    PatientRecord pr1 = new PatientRecord(101, "Ravi", 40, "Fever");
                    PatientRecord pr2 = new PatientRecord(102, "Suresh", 35, "Diabetes");
                    PatientRecord pr3 = new PatientRecord(103, "Mahesh", 50, "BP");

                    pr1.Display();
                    pr2.Display();
                    pr3.Display();

                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}