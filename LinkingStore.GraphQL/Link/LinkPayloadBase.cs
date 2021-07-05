using System.Collections.Generic;
using LinkingStore.GraphQL.Common;
using LinkingStore.GraphQL.Data.Models;

namespace LinkingStore.GraphQL.Link
{
  public class LinkPayloadBase : Payload
  {
    protected LinkPayloadBase(WebSite link)
    {
      Link = link;
    }

    protected LinkPayloadBase(IReadOnlyList<UserError> errors) : base(errors) { }

    public WebSite? Link { get; }
  }
}