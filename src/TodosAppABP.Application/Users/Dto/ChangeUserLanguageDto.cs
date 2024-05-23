using System.ComponentModel.DataAnnotations;

namespace TodosAppABP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}