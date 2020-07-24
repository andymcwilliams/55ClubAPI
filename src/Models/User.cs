using System.ComponentModel.DataAnnotations;

namespace FiftyFiveClubApi.Models
{
    public class User 
    {
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string Caption { get; set; } = "Doesnt Fancy a Caption";
    }
}
