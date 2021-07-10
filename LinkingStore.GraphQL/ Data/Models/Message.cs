using System;
using System.ComponentModel.DataAnnotations;

namespace LinkingStore.GraphQL.Data.Models
{
  public class Message
  {
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Content { get; set; }
    [Required]
    public string CreatedBy { get; set; }
    [Required]
    public Guid LinkId { get; set; }

    public LinkInfo LinkInfo { get; set; }
  }
}