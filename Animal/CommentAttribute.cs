namespace Animal;

public class CommentAttribute :Attribute
{
  public string Comment;

  public CommentAttribute(string comment)
  {
    this.Comment = comment;
  }
}