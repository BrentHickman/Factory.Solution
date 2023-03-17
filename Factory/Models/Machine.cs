using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string MachineName { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/d/yyyy}")]
    public DateTime InstallDate { get; set; }

    public List<EngMach> JoinEntities { get; }
  }
}