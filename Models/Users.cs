using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminDashboard_UI.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string? Name { get; set; }
        [MaxLength(40)]
        public string? Email { get; set; }
        [MaxLength(20)]
        public string? Role { get; set; }
        public string? Password { get; set; }
    }
}
