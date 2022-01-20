using System;
using System.Collections.Generic;

namespace SummarizingTextLiveMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be very very very very long text";

            var Summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(Summary);
        }
       
    }
}
