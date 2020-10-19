using SQLite;

namespace AppXF.Models
{
    /// <summary>
    /// Person model class
    /// </summary>
    public class M_Person
    {
        public M_Person()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int PersonID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
