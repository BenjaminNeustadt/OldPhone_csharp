using System;
using System.Text.RegularExpressions;

namespace OldPhone.Translate
{
    public class OldPhonePad
    {
        public string Translate(string input)
        {
          return Decode(input);
        }

        private string Decode(string input)
        {
          string pattern = @"(0+|1+|2+|3+|4+|5+|6+|7+|8+|9+|\*)";
          Regex regex = new Regex(pattern);
          string[] keypad_entries = regex.Split(input);
          var extracted_entries = keypad_entries.ToList();
          extracted_entries.RemoveAll(element => (element == " " || element == ""));
          string[] letters = extracted_entries.Select(s => s.Replace(s, ValueLookup[s])).ToArray();
          string message = string.Join("", letters);
          return message;
        }


        private Dictionary<string, string>  ValueLookup = new Dictionary<string, string>
        {
          [ "1" ]   =  "&",
          ["11"]   =  ",",
          ["111"]  =  "(",
          ["0"]    =  " ",
          ["2"]    =  "A",
          ["22"]   =  "B",
          ["222"]  =  "C",
          ["3"]    =  "D",
          ["33"]   =  "E",
          ["333"]  =  "F",
          ["4"]    =  "G",
          ["44"]   =  "H",
          ["444"]  =  "I",
          ["5"]    =  "J",
          ["55"]   =  "K",
          ["555"]  =  "L",
          ["6"]    =  "M",
          ["66"]   =  "N",
          ["666"]  =  "O",
          ["7"]    =  "P",
          ["77"]   =  "Q",
          ["777"]  =  "R",
          ["7777"] =  "S",
          ["8"]    =  "T",
          ["88"]   =  "U",
          ["888"]  =  "V",
          ["9"]    =  "W",
          ["99"]   =  "X",
          ["999"]  =  "Y",
          ["9999"] =  "Z"
        };
    }
}
