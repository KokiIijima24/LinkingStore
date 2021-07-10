using System.Linq;
using HotChocolate;
using LinkingStore.GraphQL.Data;
using LinkingStore.GraphQL.Data.Models;

namespace LinkingStore.GraphQL
{
    public class Query
    {
        public IQueryable<LinkInfo> GetLinkInfos([Service] ApplicationDbContext context) =>
            context.LinkInfos;
    }
}