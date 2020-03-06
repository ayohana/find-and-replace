namespace FindAndReplace.Models
{
  public class Words
  {
    public string NewSentence { get; set; }

    public string FindAndReplace(string sentence, string searchFor, string replaceWith)
    {
      int startSentence = 0;
      int startWordFound = sentence.IndexOf(searchFor);
      int endWordFound = startWordFound + searchFor.Length;

      if (sentence.IndexOf(searchFor) != -1)
      {
        NewSentence = sentence.Substring(startSentence, startWordFound);
        //stringName.Substring(firstParam, secondParam) will return a substring starting from firstParam to secondParam. However, keep in mind that when handling substrings, this method might not take empty spaces into account of the substring's index number.

        NewSentence += replaceWith;
        
        NewSentence += sentence.Substring(endWordFound);
        //stringName.Substring(singleParameter) will return a substring starting from singleParameter until the end of the stringName.
      }
      return NewSentence;
    }
    
  }
}
