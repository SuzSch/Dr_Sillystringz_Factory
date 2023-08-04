using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineer name is required.")]
    public string EngineerName { get; set; }

    [Required(ErrorMessage = "Hire date is required.")]
    public string HireDate { get; set; }
    
    [Required(ErrorMessage = "Favorite snack is required.")]
    public string FavoriteSnack { get; set; }
    public int MachineId { get; set; }
   
    public List<EngineerMachine> JoinEntities { get; }
  }
}