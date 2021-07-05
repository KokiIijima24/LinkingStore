using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GreenDonut;
using HotChocolate.DataLoader;
using LinkingStore.GraphQL.Data;
using LinkingStore.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkingStore.GraphQL.DataLoader
{
  public class WebSiteByIdDataLoader : BatchDataLoader<Guid, WebSite>
  {

    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

    public WebSiteByIdDataLoader(
        IBatchScheduler batchScheduler,
        IDbContextFactory<ApplicationDbContext> dbContextFactory)
        : base(batchScheduler)
    {
      _dbContextFactory = dbContextFactory ??
          throw new ArgumentNullException(nameof(dbContextFactory));
    }

    protected override async Task<IReadOnlyDictionary<Guid, WebSite>> LoadBatchAsync(IReadOnlyList<Guid> keys, CancellationToken cancellationToken)
    {
      await using ApplicationDbContext dbContext =
          _dbContextFactory.CreateDbContext();

      return await dbContext.WebSite
          .Where(s => keys.Contains(s.Id))
          .ToDictionaryAsync(t => t.Id, cancellationToken);
    }
  }
}