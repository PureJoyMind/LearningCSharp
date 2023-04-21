using System;

namespace CSharpCodes
{
    public class Post
    {
        //private string _title;
        ////private int _votes;

        //public string Title
        //{
        //    get => _title;
        //    set
        //    {
        //        if (value.Trim().Split(' ').Length > 1)
        //        {
        //            Console.WriteLine("Cannot set value more than one word.");
        //            return;
        //        }
        //        _title = value.Trim();
        //    }
        //}

        //public string Description { get; set; }
        //public DateTime CreationDate { get; private set; }

        //public int Votes { get; set; }

        //public Post()
        //{
        //    CreationDate = DateTime.Now;
        //}

        //public void VoteChange(char change)
        //{
        //    if (change == 'u') Votes++;
        //    else if(change == 'd') Votes--;
        //    else Console.WriteLine("failed to change vote count!");
        //}

        //public void DisplayVotes() {
        //    Console.WriteLine(Votes);
        //}


        // Chat gtp 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; }
        public int Votes { get; private set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Created = DateTime.Now;
            Votes = 0;
            Console.WriteLine($"A post with title '{Title}' was created at {Created}.");
        }

        public void UpVote()
        {
            Votes++;
            Console.WriteLine("Post upvoted!");
        }

        public void DownVote()
        {
            Votes--;
            Console.WriteLine("Post downvoted!");
        }

        public void DisplayVotes()
        {
            Console.WriteLine($"Post: {Title}");
            Console.WriteLine($"Votes: {Votes}");
        }
    }
}