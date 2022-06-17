namespace Orientation
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public override string ToString()
        {
            return $"Hi, I'm {FullName}";
        }
    }
}