using System.ComponentModel.DataAnnotations;

namespace Fakebook.Server.Data
{
    public class Account
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Profile profile { get; set; }

    }
}
