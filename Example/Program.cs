using System;
using OmegleChatScraper;

namespace Example
{
    class Program
    {
        private static int i;
        static void Main()
        {
            string[] result = OmegleScraper.Scrape(10);
            while (i != result.Length)
            {
                Console.WriteLine(result[i]);
                i++;
            }
        }
    }
}
