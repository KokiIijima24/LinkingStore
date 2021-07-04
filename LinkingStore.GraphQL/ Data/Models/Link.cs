using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LinkingStore.GraphQL.Data.Models
{
  public class Link
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string URL { get; set; }

    public string Params { get; set; }

    public ICollection<Message> Messages { get; set; } = new List<Message>();
  }
}