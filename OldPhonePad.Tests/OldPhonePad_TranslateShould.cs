using Xunit;
using OldPhone.Translate;
using FluentAssertions;

namespace OldPhoneTranslate.Tests
{
  public class OldPhonePad_TranslateShould
  {
      [Theory]
      [InlineData("A", "2")]
      public void Translate_InputIs2_ReturnSingleCharacterString(string expected, string input)
      {
          var digit_input = new OldPhonePad();

          string result = digit_input.Translate(input);

          result.Should().Be(expected);
      }
  }
}