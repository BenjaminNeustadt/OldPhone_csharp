using Xunit;
using OldPhone.Translate;
using FluentAssertions;

namespace OldPhoneTranslate.Tests
{
  public class OldPhonePad_TranslateShould
  {
      [Theory]
      [InlineData("A", "2")]
      [InlineData("B", "22")]
      [InlineData("D", "3")]
      public void Translate_InputIsUniqueDigit_ReturnCorrespondingString(string expected, string input)
      {
          var phone = new OldPhonePad();

          string result = phone.Translate(input);

          result.Should().Be(expected);
      }

      [Theory]
      [InlineData("CAB", "222 2 22")]
      [InlineData("FED", "333 33 3")]
      [InlineData("ILL", "444555 555")]
      public void Translate_InputIsMultipleDigit_CorrespondingString(string expected, string input)
      {
          var phone = new OldPhonePad();

          string result = phone.Translate(input);

          result.Should().Be(expected);
      }

      [Theory]
      [InlineData("", "222*")]
      [InlineData("A", "2 222*")]
      [InlineData("ALL", "2 555 555222*")]
      [InlineData("ALL", "2 555 555222*222*")]
      [InlineData("SLEEP", "7777 555 55* 336* 33 7666*")]
      public void Translate_InputHasDelete_CorrespondingString(string expected, string input)
      {
          var phone = new OldPhonePad();

          string result = phone.Translate(input);

          result.Should().Be(expected);
      }
  }
}
