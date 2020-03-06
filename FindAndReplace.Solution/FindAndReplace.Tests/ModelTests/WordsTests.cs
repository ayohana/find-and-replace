using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class WordsTests
  {

    [TestMethod]
    public void WordsConstructor_CreatesInstanceOfWords_Words()
    {
      Words newWords = new Words();
      Assert.AreEqual(typeof(Words), newWords.GetType());
    }

    [TestMethod]
    public void WordsConstructor_StoresUserInput_MultipleStrings()
    {
      Words newWords = new Words();
      newWords.FindAndReplace("Hello world", "world", "universe");
      string sentence = "Hello world";
      string searchFor = "world";
      string replaceWith = "universe";
      Assert.AreEqual(sentence, newWords.Sentence);
      Assert.AreEqual(searchFor, newWords.SearchFor);
      Assert.AreEqual(replaceWith, newWords.ReplaceWith);
    }

    [TestMethod]
    public void FindAndReplace_SearchForWordAndReplaceWord_String()
    {
      Words newWords = new Words();
      string actualOutput = newWords.FindAndReplace("Hello world", "world", "universe");
      string expectedOutput = "Hello universe";
      Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void FindAndReplace_SearchAnotherWordAndReplaceWord_String()
    {
      Words newWords = new Words();
      string actualOutput = newWords.FindAndReplace("Good morning world", "morning", "night");
      string expectedOutput = "Good night world";
      Assert.AreEqual(expectedOutput, actualOutput);
    }
  }
}