using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Magazine
    {
        public required string Name { get; set; }

        public required string NameOfPublisher { get; set; }

        public required DateOnly DateOfIssue { get; set; }

        public required int CountOfPages { get; set; }


        private List<Article> _articles = new();

        public List<Article> Articles 
        {
            get => _articles; 
            set => _articles = value; 
        }

        public void AddArticle(params Article[] articles)
        {
            ArgumentNullException.ThrowIfNull(articles);

            _articles.AddRange(articles);
        }

        public override string ToString()
        {
            return $"{Name}, {NameOfPublisher}, {DateOfIssue}, {CountOfPages}";
        }
    }
}

//1. Название журнала
//2. Название издательства
//3. Дата выпуска
//4. Количество страниц