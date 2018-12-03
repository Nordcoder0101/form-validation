using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models
{
  public class User
  {
    [Required]
    [MinLength(2)]
    [Display(Name = "Your First Name:")]
    public string FirstName { get; set; }
    [Required]
    [MinLength(2)]
    [Display(Name = "Your Last Name:")]
    public string LastName { get; set; }

    [Required]
    [Range(0, 200)]
    [Display(Name = "Your Age")]
    public int Age { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Your Email Address")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Your Password")]
    public string Password { get; set; }
  }
}