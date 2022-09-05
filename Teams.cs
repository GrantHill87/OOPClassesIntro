using System;

namespace OOPClassesIntro
{
    public class Team //The term 'class' here refers to what is known as a class keyword.
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Colors { get; set; } //We have to express the brackets right after the string, because we are creating an array, that's going be called, in another script.
        public int TeamSize { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Mascot { get; set; }
        
        public void Draft(string playerName, double round)
        {
            Console.WriteLine($"{playerName} has been drafted in the {round} round.");
            Console.WriteLine();
        }
        public void Play()
        {
            Console.WriteLine($"The {City} {Name}, based out of {State}, are now playing.");
        }
        public void Announcement()
        {
            Console.WriteLine($"The {City} {Name}, {Description}, are still wearing their {Colors} colors, and showcasing their crazy {Mascot} mascot this year.");
        }
    }
}
