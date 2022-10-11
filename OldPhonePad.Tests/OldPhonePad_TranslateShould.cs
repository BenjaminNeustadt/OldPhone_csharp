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

      [Theory]
      [InlineData("HELLO MOTO", "44 33 555 555 6660 6 666 8 666")]
      [InlineData("BEN & JERRY'S", "223366010533777 777999117777")]
      public void Translate_InputHasSpaceOrPunctuation_CorrespondingString(string expected, string input)
      {
          var phone = new OldPhonePad();

          string result = phone.Translate(input);

          result.Should().Be(expected);
      }

      [Theory]
      [InlineData("TURING", "8 88777444666*664#")]
      public void Translate_InputIsLastSpecification_CorrespondingString(string expected, string input)
      {
          var phone = new OldPhonePad();

          string result = phone.Translate(input);

          result.Should().Be(expected);
      }

  }
}

