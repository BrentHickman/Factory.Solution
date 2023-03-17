using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/d/yyyy}")]
    public DateTime HireDate { get; set; }
    public List<EngMach> JoinEntities { get; }
  }
}