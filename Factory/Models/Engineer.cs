using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public string HireDate { get; set; }
    public string FavoriteSnack { get; set; }
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}