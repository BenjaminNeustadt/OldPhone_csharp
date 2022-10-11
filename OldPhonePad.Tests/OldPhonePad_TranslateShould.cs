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
      public void Translate_InputIs2_ReturnCorrespondingString(string expected, string input)
      {
          var phone = new OldPhonePad();

          string result = phone.Translate(input);

          result.Should().Be(expected);
      }

      [Theory]
      [InlineData("A", "2 22*")]
      public void Translate_ReturnAfterDelete_CorrespondingString(string expected, string input)
      {
          var phone = new OldPhonePad();

          string result = phone.Translate(input);

          result.Should().Be(expected);
      }
  }
}
