using System.ComponentModel.DataAnnotations;

namespace Fakebook.Server.Data
{
    public class Profile
    {
        [Key]
        public string id { get; set; }
        public string college { get; set; }
        public string high_school { get; set; }
        public string from { get; set; }
        public string lives { get; set; }
        public string pronouns { get; set; }
        public string phone_number { get; set; }
    }
}
