namespace FindAndReplace.Models
{
  public class Words
  {
    public string Sentence { get; set; }
    public string SearchFor { get; set; }
    public string ReplaceWith { get; set; }

    public string FindAndReplace(string sentence, string searchFor, string replaceWith)
    {
      return "hi";
    }

    // properties, constructors, methods, etc. go here
    
  }
}
