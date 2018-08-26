using System.ComponentModel.DataAnnotations;

namespace wofuMotocycle.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}