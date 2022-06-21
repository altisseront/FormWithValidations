using System.ComponentModel.DataAnnotations;
namespace FormWithValidations.Models;
#pragma warning disable CS8618
public class User
{
    [Required]
    [MinLength(2)]
    public string Name {get;set;}
    [Required]
    public string DojoLocation {get;set;}
    [Required]
    public string FavoriteLanguage {get;set;}
    [MinLength(20, ErrorMessage ="Field should be at least 20 characters if included")]
    public string? Comment {get;set;}
}