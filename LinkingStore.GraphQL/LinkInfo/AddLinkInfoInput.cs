using System;

namespace LinkingStore.GraphQL
{
  public record AddLinkInfoInput
  (
    string Title,
    string URL,
    string Params
  );
}