//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Email
    {
        static void Main()
        {
          string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
          foreach (var email in Regex.Matches(text, @"([^\s""(),:;<>@[\]]{4,})\@(\w{3,})\.(\w{2,}(?:\.\w{2,})?)"))
          {
              Console.WriteLine(email);
          }
        }
    }

