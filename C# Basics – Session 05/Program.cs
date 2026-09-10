namespace C__Basics___Session_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 question

            Book book = new Book();

            //Console.WriteLine(book.password);

            #endregion

            #region 2 question

            Book book2 = new Book();

            Console.WriteLine(book2.copiesInStock);

            #endregion

            #region 3 question

            Book book3 = new Book();

            book3.Title = "Clean Code";

            Console.WriteLine(book3.Title);

            #endregion

            #region 4 question

            Book book4 = new Book();

            book4.Genre = Genre.Science;

            Console.WriteLine(book4.Genre);

            #endregion

            #region 5 question

            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);

            #endregion

            #region 6 question

            int genreNumber = 1;

            Genre genre = (Genre)genreNumber;

            Console.WriteLine(genre);

            #endregion

            #region 7 question

            Genre genre2 = Genre.Fiction;

            string genreText = genre2.ToString();

            Console.WriteLine(genreText);

            #endregion

            #region 8 question

            string genreText2 = "Science";

            Genre genre3 = Enum.Parse<Genre>(genreText2);

            Console.WriteLine(genre3);

            #endregion

            #region 9 question

            string genreText3 = "Mystery";

            if (Enum.TryParse<Genre>(genreText3, out Genre genre5))
            {
                Console.WriteLine(genre5);
            }
            else
            {
                Console.WriteLine("Unknown genre");

            #endregion

            }
        }
    }
}
