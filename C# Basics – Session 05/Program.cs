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
            #endregion

            #region 7 question
            #endregion

            #region 8 question
            #endregion

            #region 9 question
            #endregion

            #region 10 question
            #endregion

        }
    }
}
