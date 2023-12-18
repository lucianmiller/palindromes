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
      PalindromeChecker newPalindrome = new PalindromeChecker();
      Assert.AreEqual(typeof(PalindromeChecker), newPalindrome.GetType());
    }
  }
}