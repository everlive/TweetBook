namespace TweetBook.Contracts
{
  public class ApiRoutes
  {
    public const string Root = "api";
    public const string Version = "v1";
    public const string Base = Root + "/" + Version;

    public static class Posts
    {
      public const string GetAll = Base + "/posts";
      //public const string Create = "api/v1/posts";
      //public const string Get = "api/v1/posts/{postId}";

    }
  }
}