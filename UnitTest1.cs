using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace unittestBooks
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSizeBooksList()
        {
            const bool isBooks = true;
            List<string> BooksList = new List<string>()
            {
             "Достоевский \"Идиот\"", "Куприн \"Сборник рассказов\""
            };
            var actual = new bibliobook.Form1().UpdateBooks(BooksList);
            var expected = isBooks;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckSizeReadersList()
        {
            const bool isReaders = true;
            List<string> ReadersList = new List<string>()
            {
             "Арбузов Н.В."
            };
            var actual = new bibliobook.Form1().UpdateReaders(ReadersList);
            var expected = isReaders;
            Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void ReadersListIsEmpty()
        {
            const bool isReaders = false;
            List<string> ReadersList = null;

            var actual = new bibliobook.Form1().UpdateReaders(ReadersList);
            var expected = isReaders;
            Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void BooksListIsEmpty()
        {
            const bool isBooks = false;
            List<string> BooksList = null;
          
            bool actual = new bibliobook.Form1().UpdateBooks(BooksList);
            var expected = isBooks;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckDeletedBook()
        {
            const bool result = true;
            const string item = "Достоевский \"Идиот\"";
            List<string> BooksList = new List<string>()
            {
             "Достоевский \"Идиот\"", "Куприн \"Сборник рассказов\""
            };
            var actual = new bibliobook.Form1().RemoveBook(item, BooksList);
            var expected = result;
            Assert.AreEqual(expected, actual);
        }
    }
}




