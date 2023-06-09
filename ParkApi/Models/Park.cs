using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ParkApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    public string ParkName { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public string Description { get; set; }
  }
}
