using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The Engineer's Name field can't be empty!")]
    public string EngineerName { get; set; }
    
    [Required(ErrorMessage = "The Engineer's Hire Date field can't be empty!")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/d/yyyy}")]
    public DateTime HireDate { get; set; }
    public List<EngMach> JoinEntities { get; }
  }
}