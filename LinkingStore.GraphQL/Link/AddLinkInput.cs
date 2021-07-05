namespace LinkingStore.GraphQL.Link
{
    public record AddLinkInput(
      string Title,
      string URL,
      string Params
    );
}