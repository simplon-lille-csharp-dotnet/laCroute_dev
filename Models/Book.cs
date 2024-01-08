using System.ComponentModel.DataAnnotations;

namespace LaCroute.Models;
public class Book{
    [Key]
    public int id {get; set;}
    public DateOnly date {get; set;}
    [Required(ErrorMessage = "Veuillez sélectionner une heure.")]
    [DataType(DataType.Time)]
    public TimeSpan time {get; set;}
    public string name {get; set;}
    [Phone(ErrorMessage ="Merci de renseigner un numéro de téléphone valide")]
    public string phoneNumber {get; set;}
    [Range(1,6,ErrorMessage = "Merci de mettre entre 1 et 6 places")]
    public int seats{get; set;}

    public DateTime created_at {get; set;} = DateTime.Now;
    public DateTime updated_at {get; set;} = DateTime.Now;
}
