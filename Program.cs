using System;

namespace C_OOP_Assignment
{
    // Abstract class
    abstract class Painting
    {
        // Regular method
        public void GroupMessage()
        {
            Console.WriteLine(" ");
        }
        // Added the virtual keyword to overwrite the base class method.
        public virtual void styles()
        {
            Console.WriteLine(" ");
        }
    }

    // Derived class (child 1)
    class Name : Painting
    {
        // Field for class Name
        private string paintName;
        //property for class Name
        public string IPaintname
        {
            get { return paintName; }
            set { paintName = value; }
        }
    }
    // Derived class (child 2)
    class Artist : Painting
    {
        // Field for class Artisit
        private string artistName;
        //property for class Artist
        public string IArtistname
        {
            get { return artistName; }
            set { artistName = value; }
        }
    }
    // Derived class (child 3)
    class Medium : Painting
    {
        // Field for class Medium
        private string mediumName;
        // Property for class Medium
        public string IMediumname
        {
            get { return mediumName; }
            set { mediumName = value; }
        }
        public void myGroupMessage()
        {
            Console.WriteLine(" ");
        }
    }
    // Derived class (child 4)
    class Year : Painting
    {
        // Field for class Year
        private string yearName;
        // Property for class Year
        public string IYearname
        {
            get { return yearName; }
            set { yearName = value; }
        }
        public override void styles()
        {
            Console.WriteLine(" ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Name myName = new Name();  // create a Name object
            Artist myArtist = new Artist();  // create an Artist object
            Medium myMedium = new Medium();  // create a Medium object
            Year myYear = new Year();         // create a Year object


            myName.IPaintname = "Colorful Design";
            myArtist.IArtistname = "Taiwo Toyin";
            myMedium.IMediumname = "Social Media";
            myYear.IYearname = "2020";

            Console.WriteLine("Name: " + myName.IPaintname);
            Console.WriteLine("Artist: " + myArtist.IArtistname);
            Console.WriteLine("Medium: " + myMedium.IMediumname);
            Console.WriteLine("year: " + myYear.IYearname);
        }
    }
}
