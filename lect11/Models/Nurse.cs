using lect11.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lect11.Models
{
    internal class Nurse : User
    {
        public Nurse() : base()
        { 
            
        }
            public decimal Salary { get; set; }
        public string[] workday { get; set; } = Array.Empty<string>();

        public DOCTOR_PROFESSION[] docprof { get; set; } = Array.Empty<DOCTOR_PROFESSION>();

        public Nurse(int id, string fullname, int age, string personid, string phonenumber, decimal salary, string[] workdays, DOCTOR_PROFESSION[] doctorprofecion) : base(id, fullname, age, personid, phonenumber)
        {
            Salary = salary;
            workday = workdays;
            docprof = doctorprofecion;
        }
    
    
    }
}