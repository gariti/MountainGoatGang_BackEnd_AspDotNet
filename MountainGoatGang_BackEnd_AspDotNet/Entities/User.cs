using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MountainGoatGang.Repository
{
    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(250)]
        public string LastName { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; }

    }
}