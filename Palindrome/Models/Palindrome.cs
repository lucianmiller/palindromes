using System.Collections.Generic;
using System;

namespace Palindrome.Models
{
  public class PalindromeChecker
  {
    public string UserString { get; set; }
    public string SanitizedString { get; set; }

    public PalindromeChecker(string userInput)
    {
      UserString = userInput;
    }
  }
}