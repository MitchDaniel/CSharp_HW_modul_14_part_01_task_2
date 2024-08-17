using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Article
    {
        public required string Title { get; set; }

        public required int CountOfSymbols { get; set; }

        public required string ArticleAnnouncement {  get; set; }

        public override string ToString()
        {
            return $"{Title}, {CountOfSymbols}, {ArticleAnnouncement}";
        }
    }
}

//1. Название статьи
//2. Количество символов
//3. Анонс статьи