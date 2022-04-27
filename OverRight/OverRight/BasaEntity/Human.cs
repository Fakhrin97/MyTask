namespace OverRight.BasaEntity
{
    internal abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public string Gender { get; set; }
        
        protected byte _iq;
        public Human(string name, string surname, byte age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public abstract void Saler(byte age);
        
    }
}
