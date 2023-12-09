using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a lecture event
        var lecture = new Lecture
        {
            Title = "Science Talk",
            Description = "A lecture on recent scientific discoveries",
            Date = new DateTime(2023, 12, 10),
            Time = "2 PM",
            Address = new Address { Street = "123 Science Rd", City = "Techville", State = "Innovate", ZipCode = "12345" },
            Speaker = "Dr. Jane Doe",
            Capacity = 100
        };

        // Create a reception event
        var reception = new Reception
        {
            Title = "Annual Gala",
            Description = "A night of celebration and fundraising",
            Date = new DateTime(2023, 12, 15),
            Time = "7 PM",
            Address = new Address { Street = "456 Gala Ave", City = "Eventown", State = "Festivia", ZipCode = "67890" },
            RSVP_Email = "rsvp@galaevent.com"
        };

        // Create an outdoor gathering event
        var outdoorGathering = new OutdoorGathering
        {
            Title = "Park Concert",
            Description = "An open-air concert in the park",
            Date = new DateTime(2023, 12, 20),
            Time = "4 PM",
            Address = new Address { Street = "789 Park Ln", City = "Musicville", State = "Melodia", ZipCode = "10111" },
            WeatherForecast = "Sunny with a slight breeze"
        };

        // Display marketing messages for each event
        DisplayMarketingMessages(lecture);
        DisplayMarketingMessages(reception);
        DisplayMarketingMessages(outdoorGathering);
    }

    static void DisplayMarketingMessages(Event event) {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(event.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(event.GetShortDescription());
        Console.WriteLine("-----------------------------------------\n");
    }
}
