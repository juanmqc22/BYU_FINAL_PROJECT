using System;

namespace Practice4BYU 
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>() { "Miguel", "Bia", "Julia", "Jose", "Quezada", "Pedro", "Juan", "Manuel" };
            List<string> Comments = new List<string>() { "I like it", "I hate it", "I love it", "Nice!", "Sweet!", "Awesome" };
            List<string> Titles = new List<string>() { "How to dance?", "How to play tekken?", "How to win a game?" };
            List<Video> videos_list = new List<Video>();

            for (int i = 0; i < 3; i++)
            {
                Video video = new Video();
                video.Author = get_random(Names);
                video.Title = get_random(Titles);
                video.Length = get_random_number();
                video.Comments = get_comment(Names, Comments);
                videos_list.Add(video);
            }
            display();

            void display()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($" Title: {videos_list[i].Title}");
                    Console.WriteLine($"   * Author: {videos_list[i].Author}");
                    Console.WriteLine($"   * Length: {videos_list[i].Length} Seg.");
                    Console.WriteLine($"   * Comments:");
                    Console.WriteLine("");
                    display_comments(videos_list[i].Comments);
                    Console.WriteLine("-------------");
                }
            }

            string get_random(List<string> array)
            {
                var random = new Random();
                int randIndex = random.Next(array.Count);
                return array[randIndex];
            }

            void display_comments(List<string> Comments)
            {
                for (int i = 0; i < 3; i++)
                {
                    var counter = i * 2;
                    Console.WriteLine($"   - Comment {i+1}");
                    Console.WriteLine($"       Name: {Comments[counter]}");
                    Console.WriteLine($"       Comment: {Comments[counter+1]}");
                }
            }

            List<string> get_comment(List<string> Names, List<string> Comments)
            {
                List<string> pack_comments = new List<string>();

                for (int i = 0; i < 3; i++)
                {
                    string name = get_random(Names);
                    string comment = get_random(Comments);
                    pack_comments.Add(name);
                    pack_comments.Add(comment);
                }

                return pack_comments;
            }
            int get_random_number()
            {
                var random = new Random();
                return random.Next(1000);
            }

        }

    }
    class Video
    {
        public string Title = "";
        public string Author = "";
        public int Length = 0;
        public List<string> Comments;
    }
    public class Comments
    {
        public string Name = "";
        public string Comment = "";
    }

}