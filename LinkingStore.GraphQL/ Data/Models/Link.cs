using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LinkingStore.GraphQL.Data.Models
{
  public class WebSite
  {
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string URL { get; set; }

    public string Params { get; set; }

    public ICollection<Message> Messages { get; set; } = new List<Message>();
  }
}