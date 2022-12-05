using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.Riddle
{
  public class Riddle
  {
    private Dictionary<string, string> _riddlePairs = new Dictionary<string, string>() {
      {"What gets wet while drying?","towel"},
      {"What can you catch, but not throw", "cold" },
      {"What has many teeth, but cannot bite?","comb" }
    };

    private string _currentAnswer;

    public string GetRiddle()
    {
      return GetRandom();
    }

    private string GetRandom()
    {

      string riddle = "";
      Random rnd = new Random();
      int index = rnd.Next(0, _riddlePairs.Count - 1);

      riddle = _riddlePairs.ElementAt(index).Key;
      _currentAnswer = _riddlePairs.ElementAt(index).Value;

      return riddle;
    }

    public bool checkAnswer(string answer)
    {
      bool answerFound = answer.Trim().ToLower().Contains(_currentAnswer);
      return answerFound;
    }
  }
}
