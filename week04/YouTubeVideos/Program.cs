using System;

class Program
{
    static void Main(string[] args)
    {
        List<videos> myVideo = new List<videos>();

        videos v1 = new videos("About c#", "Jeremias", 480);
        v1.AddComment(new comment("Bob", "The best"));
        v1.AddComment(new comment("Josh", "Thanks for your video"));
        v1.AddComment(new comment("Barbara", "Great explanation"));
        myVideo.Add(v1);


        comment c1v2 = new comment("Carol", "Thanks for this.");
        videos v2 = new videos("Polymorphism Explained", "John", 750);
        v2.AddComment(c1v2);
        v2.AddComment(new comment("Eva", "Finally I understand it!"));
        v2.AddComment(new comment("Frank", "Simple and clear."));
        myVideo.Add(v2);

        videos v3 = new videos("LINQ Tutorial", "Sara", 350);
        v3.AddComment(new comment("Harry", "Wow, LINQ is powerful."));
        v3.AddComment(new comment("Ivy", "Neatly presented."));
        v3.AddComment(new comment("Jack", "I learned a lot."));
        myVideo.Add(v3);

        foreach (videos v in myVideo)
        {
            v.DisplayVideo();
        }
    }
}