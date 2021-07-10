using System.Threading.Tasks;
using HotChocolate;
using LinkingStore.GraphQL.Data;
using LinkingStore.GraphQL.Data.Models;

namespace LinkingStore.GraphQL
{
    public class LinkInfoMutation
    {
      public async Task<AddLinkInfoPayload> AddLinkInfoAsync(
        AddLinkInfoInput input,
        [Service] ApplicationDbContext context
      ){
        var linkInfo = new LinkInfo{
          Title = input.Title,
          URL = input.URL,
          Params = input.Params
        };

        context.LinkInfos.Add(linkInfo);
        await context.SaveChangesAsync();

        return new AddLinkInfoPayload(linkInfo);
      }
    }
}