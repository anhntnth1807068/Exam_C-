namespace exampaper.entity
{
    public class People
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            var stringGender = Gender ? "Male" : "Female";
            return $"Name = {Name},Gender ={stringGender},Age = {Age}";
        }
    }
}