using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    [Display(Name = "Destination")]

    public string DestinationName { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    [Display(Name = "State/Province")]
    public string StateProvince { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Category { get; set; }
    [Range(1, 5, ErrorMessage = "Rating must be from 1 as the lowest and 5 as the highest.")]
    public int Rating { get; set; }
    [Required]
    [Display(Name = "Description")]
    public string DestinationDescription { get; set; }

  }
}