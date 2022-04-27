using OverRight.BasaEntity;
using OverRight.Interfaces;

namespace OverRight
{
    internal class Doctor : Human, IMentable
    {

        public string Hospital { get; set; }
        public byte Iq
        {
            get => _iq; 
            set
            {
                if (value>90)
                {
                    _iq = value;
                }
                else
                {
                    System.Console.WriteLine("Iq-su zeifdi");
                }
            }
        }

        public Doctor(string name, string surname, byte age, string gender, string hospital) : base(name, surname, age, gender)
        {
            Hospital = hospital;
        }

        public override void Saler(byte age)
        {

        }
    }
}
