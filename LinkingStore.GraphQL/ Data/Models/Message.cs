using System.ComponentModel.DataAnnotations;

namespace LinkingStore.GraphQL.Data.Models
{
  public class Message
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Content { get; set; }
    [Required]
    public string CreatedBy { get; set; }
    [Required]
    public int LinkId { get; set; }

    public WebSite WebSite { get; set; }
  }
}