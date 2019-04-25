using System;

namespace RegexApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var matcher = new RegexMatches();
      var toSearch =
        "Alice's B-day: 01-01-1991\n" + "Betty's B-day: 02-02-1992\n" +
        "Cindy's B-day: 03-03-1993\n" + "Diane's B-day: 04-04-1994\n" +
        "Eileen's B-day: 05-05-1995\n" + "Gloria's B-day: 06-06-1991\n" +
        "Helene's B-day: 07-07-1992\n" + "Irene's B-day: 08-08-1993\n" +
        "Judy's B-day: 09-09-1994\n" + "Karen's B-day: 10-10-1995\n" +
        "Linda's B-day: 11-11-2001\n" + "Mary's B-day: 12-12-2002\n" +
        "Nancy's B-day: 01-13-2003\n" + "Olivia's B-day: 02-14-2004\n" +
        "Pamela's B-day: 03-15-2005\n" + "Rene's B-day: 04-20-2001\n" +
        "Susan's B-day: 05-22-2002\n" + "Tina's B-day: 06-25-2003\n" +
        "Ursula's B-day: 07-28-2004\n" + "Virginia's B-day: 08-31-2005\n" +
        "Wendy's B-day: 09-30-2006\n";
      var matches = matcher.findMatches(toSearch);
      for (int i = 0; i < 4; i++)
      {
        Console.WriteLine(matches[i]);
      }
      Console.WriteLine("...  // Here are 11 other girls’ B-days.");
      for (int i = 16; i < 21; i++)
      {
        Console.WriteLine(matches[i]);
      }
      Console.ReadKey();
    }
  }
}
