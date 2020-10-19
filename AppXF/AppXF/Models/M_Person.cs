using SQLite;

namespace AppXF.Models
{
    /// <summary>
    /// Person model class
    /// </summary>
    public class M_Person
    {
        public M_Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        [PrimaryKey, AutoIncrement]
        public int PersonID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
