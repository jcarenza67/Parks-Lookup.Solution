using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ParkApi.Models
{
  public class Park
  {
    public string ParkId { get; set; }
    [Required]
    public string ParkName { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string UserName { get; set; }
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set; }
    [Required]
    public DateTime Date { get; set; }


  }
}
