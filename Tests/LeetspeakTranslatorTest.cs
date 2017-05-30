using Xunit;
using System;
using System.Collections.Generic;

namespace LeetSpeakTranslator
{
  public class LeetSpeakTranslatorTest : IDisposable
  {
    [Fact]
    public void IsCharacterInStringE_ReplaceWith3()
    {
      LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
      Assert.Equal("h3lium", newTranslator.Translate("helium"));
    }
    [Fact]
    public void IsCharacterInStringO_ReplaceWith0()
    {
      LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
      Assert.Equal("h3ll0", newTranslator.Translate("hello"));
    }
    [Fact]
    public void IsCharacterInStringI_ReplaceWith1()
    {
      LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
      Assert.Equal("1ndia", newTranslator.Translate("India"));
    }
    [Fact]
    public void IsCharacterInStringT_ReplaceWith7()
    {
      LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
      Assert.Equal("70ma70", newTranslator.Translate("Tomato"));
    }
    [Fact]
    public void IsCharacterInStringS_RepalceWithZ()
    {
      LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
      Assert.Equal("7hiz iz a S3n73nc3", newTranslator.Translate("This is a Sentence"));
    }
    public void Dispose()
    {
      LeetSpeakTranslator.DeleteAll();
    }
  }
}
