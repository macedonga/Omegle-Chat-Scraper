using System;
using System.Collections.Generic;

namespace OmegleChatScraper
{
    public static class OmegleScraper
    {
        private static readonly string[] val = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
        private const string url = "l.omegle.com/";
        /// <summary>
        /// Returns an array with <paramref name="num"/> of Omegle chat links.
        /// </summary>
        /// <returns>
        /// A specified number of Omegle chat links.
        /// </returns>
        /// <example>
        /// <code>
        /// string[] result = OmegleScraper.Scrape(1);
        /// Console.WriteLine(result[0]):
        /// Environment.Exit(0);
        /// </code>
        /// </example>
        /// See <see cref="Scrape(int)"/> to generate Omegle chat links.
        /// <param name="num">The number of links that the library must generate.</param>
        public static string[] Scrape(int num)
        {
            var links = new List<string>();
            int i = 0;
            while ((i++) != num)
            {
                Random rnd = new Random();
                links.Add(url + val[rnd.Next(val.Length)] + val[rnd.Next(val.Length)] + val[rnd.Next(val.Length)] + val[rnd.Next(val.Length)] + val[rnd.Next(val.Length)] + ".png");
            }
            return links.ToArray();
        }
    }
}
