using lect11.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace lect11.Models
{
    internal class Doctor : User
    {
        public decimal salary { get; set; }

        public string[] workdays { get; set; } = Array.Empty<string>();

        public DOCTOR_PROFESSION[] doctorprofesion { get; set; } = Array.Empty<DOCTOR_PROFESSION>();
        public Doctor() : base()
        {
            
        }
        public Doctor(int id, string fullname, int age, string personid, string phonenumber , decimal salary,string[] workdays, DOCTOR_PROFESSION[] doctorprofecion) : base(id , fullname, age , personid, phonenumber)
        {
            this.salary = salary;
            this.workdays = workdays;
            this.doctorprofesion = doctorprofecion;
        }
    }
}
