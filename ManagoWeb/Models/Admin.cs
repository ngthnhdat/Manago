using System.ComponentModel.DataAnnotations;

namespace ManagoWeb.Models
{
    public class Admin
    {

        [Key]
        public int admin_id { get; set; }
        [Required]
        public string admin_name { get; set; }
        public string admin_password { get; set; }
        public string admin_email { get; set; }

    }
}
