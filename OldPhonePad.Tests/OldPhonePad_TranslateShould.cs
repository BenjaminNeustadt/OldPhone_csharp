using Xunit;
using OldPhone.Translate;
using FluentAssertions;

namespace OldPhoneTranslate.Tests
{
  public class OldPhonePad_TranslateShould
  {
      [Fact]
      public void Translate_InputIs2_ReturnSingleCharacterString()
      {
          var digit_input = new OldPhonePad();

          string result = digit_input.Translate("2");

          result.Should().Be("A");
      }
  }
}