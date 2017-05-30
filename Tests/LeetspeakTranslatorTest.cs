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
      Assert.Equal("h3llo", newTranslator.Translate("hello"));
    }
    [Fact]
    public void IsCharacterInStringO_ReplaceWith0()
    {
    LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
    Assert.Equal("h3ll0", newTranslator.Translate("hello"));
    }
    public void Dispose()
    {
      LeetSpeakTranslator.DeleteAll();
    }
  }
}
