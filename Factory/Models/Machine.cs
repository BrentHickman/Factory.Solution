using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "The Machine's Name field can't be empty!")]
    public string MachineName { get; set; }

    [Required(ErrorMessage = "The Machine's Install Date field can't be empty!")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/d/yyyy}")]
    public DateTime InstallDate { get; set; }

    public List<EngMach> JoinEntities { get; }
  }
}