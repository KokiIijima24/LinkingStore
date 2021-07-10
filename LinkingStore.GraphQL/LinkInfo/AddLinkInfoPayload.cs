using LinkingStore.GraphQL.Data.Models;

namespace LinkingStore.GraphQL
{
  public class AddLinkInfoPayload
  {
    public AddLinkInfoPayload(LinkInfo linkInfo)
    {
      LinkInfo = linkInfo;
    }

    public LinkInfo LinkInfo { get; }
  }
}