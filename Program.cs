using System.Xml.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Magazine[] magazines =
            //[
            //    new Magazine
            //    {
            //        Name = "Murzilca",
            //        NameOfPublisher = "BestForChildren",
            //        DateOfIssue = new DateOnly(2024, 8, 1),
            //        CountOfPages = 15
            //    },
            //    new Magazine
            //    {
            //        Name = "Cosmopolitan",
            //        NameOfPublisher = "WomewWorld",
            //        DateOfIssue = new DateOnly(2024, 7, 10),
            //        CountOfPages = 73
            //    },
            //    new Magazine
            //    {
            //        Name = "Sudoku",
            //        NameOfPublisher = "BrainFuck",
            //        DateOfIssue = new DateOnly(2024, 7, 20),
            //        CountOfPages = 21
            //    }
            //];
            //magazines[0].AddArticle(
            //    new Article 
            //    { 
            //        Title = "How build first rocket?",
            //        ArticleAnnouncement = "Take a paper...",
            //        CountOfSymbols = 2000
            //    },
            //    new Article
            //    {
            //        Title = "You can study better!",
            //        ArticleAnnouncement = "Have bad marks?",
            //        CountOfSymbols = 3000
            //    }
            //    );
            //magazines[1].AddArticle(
            //   new Article
            //   {
            //       Title = "Wow! You are wonder woman",
            //       ArticleAnnouncement = "Have a date?..",
            //       CountOfSymbols = 4000
            //   },
            //   new Article
            //   {
            //       Title = "I am smart, but live as stupid",
            //       ArticleAnnouncement = "We make a lot of decisions every day...",
            //       CountOfSymbols = 6000
            //   }
            //   );
            //magazines[2].AddArticle(
            //   new Article
            //   {
            //       Title = "CrossWord",
            //       ArticleAnnouncement = "Guess all words",
            //       CountOfSymbols = 1000
            //   }
            //   );

            //MagazineManager.SerializeMagazinesToXML(magazines, @"C:\Users\Brill\Desktop\Magazines.xml");
            var magazines2 = MagazineManager.DeserializeMagazines(@"C:\Users\Brill\Desktop\Magazines.xml");
            foreach (var magazine in magazines2)
            {
                Console.WriteLine(magazine);
                foreach (var articles in magazine.Articles)
                {
                    Console.WriteLine(articles);
                }
            }
        }
    }
}

//Задание 2:
//Создайте программу для работы с информацией о журнале. Нужно хранить такую информацию об журнале:
//1. Название журнала
//2. Название издательства
//3. Дата выпуска
//4. Количество страниц
//У программы должна быть такая функциональность:
//1. Ввод информации о журнале
//2. Вывод информации о журнале
//3. Сериализация журнала
//4. Сохранение сериализованного журнала в файл
//5. Загрузка сериализованного журнала из файла. После загрузки нужно произвести десериализацию журнала.
//Задание 3:
//Добавьте к предыдущему заданию список статей из журнала. Нужно хранить такую информацию о каждой статье:
//1. Название статьи
//2. Количество символов
//3. Анонс статьи
//Измените функциональность из предыдущего задания таким образом, чтобы она учитывала список статей.
//Задание 4:
//Добавьте к предыдущему заданию возможность создания массива журналов.
//Измените функциональность из второго задания таким образом, чтобы она учитывала массив журналов.
//Выбор конкретного формат сериализации необходимо сделать вам. Обращаем ваше внимание, что выбор должен быть обоснованным.