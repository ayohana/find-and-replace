using System;

namespace FindAndReplace.Models
{
  public class Words
  {
    public string Sentence { get; set; }
    public string SearchFor { get; set; }
    public string ReplaceWith { get; set; }
    public string NewSentence { get; set; }

    public string FindAndReplace(string sentence, string searchFor, string replaceWith)
    {
      Sentence = sentence;
      SearchFor = searchFor;
      ReplaceWith = replaceWith;

      if (Sentence.IndexOf(SearchFor) != -1)
      {
        NewSentence = Sentence.Substring(0, Sentence.IndexOf(SearchFor));
        NewSentence += ReplaceWith;
      }
      Console.WriteLine(NewSentence);
      return NewSentence;
    }
    
  }
}
