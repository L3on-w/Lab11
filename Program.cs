using System;
using System.Collections.Generic;
using System.Linq;



namespace movie
{
    internal class program {


        public List<Title> Movie = new List<Title>();
        Movie.Add(Star Wars, scifi);
        Movie.Add(Title(){"Star Trek" "scifi"});
        Movie.Add(Title("Aliens" "scifi"));
        Movie.Add(Title("Wreck it Ralph" "animated"));
        Movie.Add(Title("Toy Story" "animated"));
        Movie.Add(Title("Spider-Man: Into the Spider-Verse" "animated"));
        Movie.Add(Title("Saw" "horror"));
        Movie.Add(Title("Get Out" "horror"));
        Movie.Add(Title("Knives out" "drama"));
        Movie.Add(Title("The Social Network" "drama"));

        foreach (Title title in Movie)
        {
            Console.WriteLine(title);
        }


       
    }
}
