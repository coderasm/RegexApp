using System.Text.RegularExpressions;

namespace RegexApp
{
  class RegexMatches
  {
    public Regex expression { get; set; } = new Regex(@".*\d[\d-[4]]-\d\d-\d\d");

    public string[] findMatches(string toSearch)
    {
      var matches = expression.Matches(toSearch);
      string[] matchStrings = new string[matches.Count];
      for (int i = 0; i < matches.Count; i++)
      {
        matchStrings[i] = matches[i].Value;
      }
      return matchStrings;
    }
  }
}
