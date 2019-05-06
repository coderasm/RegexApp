using System.Text.RegularExpressions;

namespace RegexApp
{
  class RegexMatches
  {
    private Regex expression = new Regex(@".*\d\d-\d\d-\d{4}");

    public void setExpression(string expression)
    {
      this.expression = new Regex(expression);
    }

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
