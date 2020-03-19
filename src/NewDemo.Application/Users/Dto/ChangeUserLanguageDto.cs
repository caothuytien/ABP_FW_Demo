using System.ComponentModel.DataAnnotations;

namespace NewDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}