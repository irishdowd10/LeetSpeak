using Nancy;
using System.Collections.Generic;
using LeetSpeakTranslatorProject.Objects;

namespace LeetSpeakTranslatorProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<char> _letters = new List<char>{};
        LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
        return View["index.cshtml", _letters];
      };
      Post["/"] = _ => {
        LeetSpeakTranslator.DeleteAll();
        LeetSpeakTranslator newTranslator = new LeetSpeakTranslator();
        string result = newTranslator.Translate(Request.Form["new-phrase"]);
        return View["index.cshtml", result];
      };
    }
  }
}
