using System;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using LinkingStore.GraphQL.Data;
using LinkingStore.GraphQL.Data.Models;

namespace LinkingStore.GraphQL.Link
{
  [ExtendObjectType(Name = "Mutation")]
  public class LinkMutation
  {
    [UseApplicationDbContext]
    public async Task<AddLinkPayload> AddLinkAsync(
        AddLinkInput input,
        [ScopedService] ApplicationDbContext context)
    {
      var link = new WebSite
      {
        Id = Guid.NewGuid(),
        Title = input.Title,
        URL = input.URL,
        Params = input.Params
      };

      context.WebSite.Add(link);
      await context.SaveChangesAsync();

      return new AddLinkPayload(link);
    }
  }
}