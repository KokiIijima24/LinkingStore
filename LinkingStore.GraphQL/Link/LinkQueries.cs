using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using LinkingStore.GraphQL.Data;
using LinkingStore.GraphQL.Data.Models;
using LinkingStore.GraphQL.DataLoader;
using Microsoft.EntityFrameworkCore;

namespace LinkingStore.GraphQL.Link
{
  [ExtendObjectType(Name = "Query")]
  public class WebSiteQueries
  {
    [UseApplicationDbContext]
    public Task<List<WebSite>> GetSpeakers([ScopedService] ApplicationDbContext context) =>
   context.WebSite.ToListAsync();

    public Task<WebSite> GetSpeakerAsync(
      Guid id,
      WebSiteByIdDataLoader dataLoader,
      CancellationToken cancellationToken) =>
dataLoader.LoadAsync(id, cancellationToken);
  }
}