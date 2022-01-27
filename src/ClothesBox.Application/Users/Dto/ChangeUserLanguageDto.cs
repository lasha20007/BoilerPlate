using System.ComponentModel.DataAnnotations;

namespace ClothesBox.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}