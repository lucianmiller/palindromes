using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void PalindromeConstructor_CreatesInstanceOfPalindrome_Palindrome()
    {
      string userInput = "Race car";
      PalindromeChecker newPalindrome = new PalindromeChecker(userInput);
      Assert.AreEqual(typeof(PalindromeChecker), newPalindrome.GetType());
    }

    [TestMethod]
    public void GetUserString_ReturnsUserString_String()
    {
      string userInput = "Race car";
      PalindromeChecker newPalindrome = new PalindromeChecker(userInput);
      string result = newPalindrome.UserString;
      Assert.AreEqual(userInput, result);
    }
  }
}