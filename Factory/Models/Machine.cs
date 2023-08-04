using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine name is required.")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "Install Date is required.")]
    public string InstallDate { get; set; }
    public int EngineerId { get; set; }

    public List<EngineerMachine> JoinEntities { get; }
  }
}