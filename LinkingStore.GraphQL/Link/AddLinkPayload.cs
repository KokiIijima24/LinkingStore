using System.Collections.Generic;
using LinkingStore.GraphQL.Common;
using LinkingStore.GraphQL.Data.Models;

namespace LinkingStore.GraphQL.Link
{
  public class AddLinkPayload : LinkPayloadBase
  {
    public AddLinkPayload(WebSite link) : base(link)
    {
    }

    public AddLinkPayload(IReadOnlyList<UserError> errors) : base(errors)
    {
    }
  }
}