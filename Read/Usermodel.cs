using System.ComponentModel.DataAnnotations;
namespace Read;
public class Usermodel{
    [Key]
    public int Id{get;set;} 
    [Required]
    public string? Username{get;set;}
    [Required]
     public string? Email{get;set;}
     [Required]
    public string? Password{get;set;}
}