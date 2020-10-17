namespace AppXF.Models
{
    public class M_Person
    {
        public M_Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
