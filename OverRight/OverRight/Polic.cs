using OverRight.BasaEntity;
using OverRight.Interfaces;
using System;

namespace OverRight
{
    internal class Polic : Human, IMentable
    {
        public string Rutbe { get; set; }
        public byte Iq
        {
            get => _iq;
            set
            {
                if (value > 100)
                {
                    _iq = value;
                }
            }
        }

        public Polic(string name, string surname, byte age, string gender, string rutbe) : base(name, surname, age, gender)
        {
            Rutbe = rutbe;


        }
        public override void Saler(byte age)
        {
            Console.WriteLine($"Saler:{age}$");
        }
        public void add(Doctor doctor)
        {
            Console.WriteLine(doctor.Iq);
        }
    }

}

