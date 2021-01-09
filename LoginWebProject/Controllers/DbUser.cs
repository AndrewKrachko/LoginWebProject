using System.Data.Linq.Mapping;

namespace LoginWebProject.ControllerS
{
    [Table(Name = "Users")]
    public class DbUser
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "User")]
        public string Name { get; set; }
        [Column(Name = "Password")]
        public string Password { get; set; }
    }
}