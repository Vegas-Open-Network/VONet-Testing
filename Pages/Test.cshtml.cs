using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace VONetTesting.Pages
{
    public class TestModel : PageModel
    {
        public int RandomNumber { get; private set; }
        public string RandomString { get; private set; } = string.Empty;
        public DateTime CurrentTime { get; private set; }
        public IReadOnlyList<string> RandomFacts { get; private set; } = new List<string>();

        public void OnGet()
        {
            var rnd = new Random();
            RandomNumber = rnd.Next(1, 1000);
            RandomString = Guid.NewGuid().ToString().Substring(0, 8);
            CurrentTime = DateTime.Now;
            RandomFacts = new List<string>
            {
                "Bananas are berries, but strawberries aren't.",
                "Honey never spoils.",
                "A group of flamingos is called a 'flamboyance'.",
                "Octopuses have three hearts.",
                "The unicorn is the national animal of Scotland."
            };
        }
    }
}
