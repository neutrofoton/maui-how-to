using System;
namespace Maui10ExWeather.Models.Domain
{
    public class PhraseOnly
    {
        public string Phrase { get; set; }

        public string IconPhrase
        {
            set { Phrase = value; }
        }
    }
}

