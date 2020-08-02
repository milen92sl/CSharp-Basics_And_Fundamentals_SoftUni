using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ") ;

                Article myArticle = new Article(tokens[0], tokens[1], tokens[2]);
                list.Add(myArticle);
            }

            List<Article> sortedArticles = new List<Article>();
            Console.WriteLine(string.Join(" ", sortedArticles));
            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
              sortedArticles = list.OrderBy(a => a.Title).ToList();
            }
            else if (criteria == "author")
            {
                sortedArticles = list.OrderBy(a => a.Author).ToList();
            }
            else
            {
                sortedArticles = list.OrderBy(a => a.Content).ToList();
            }

            sortedArticles
                .ForEach(x => Console.WriteLine(x));
        }

    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public override string ToString()
        {
            return ($"{this.Title} - {this.Content}: {this.Author}");
        }
    }
}
