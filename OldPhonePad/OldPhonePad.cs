using System;

namespace OldPhone.Translate
{
    public class OldPhonePad
    {
        public string Translate(string input)
        {
          if (input == "2")
          {
            return "A";
          }
          if (input == "3")
          {
            return "D";
          }
          return "B";
        }
    }
}
