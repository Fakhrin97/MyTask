using System;

namespace OverRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 45;
            Doctor doctor = new Doctor("Elabbes", "Eshrefov", age, "Fmale", "Zerife");
            doctor.Saler(age);
            doctor.Iq = 91;
            byte age1 = 60;
            Polic polic = new Polic("Elabbes", "Eshrefov", age1, "Fmale", "Zerife");

            polic.add(doctor);
            polic.Saler(age1);  
            


        }
    }
}
