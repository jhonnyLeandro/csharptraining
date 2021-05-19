using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjcets()
        {
            var book = GetBook("Book 1");
            var book1 = GetBook("Book 2");

            Assert.Equal("Book 1", book.Name);
            Assert.Equal("Book 2", book1.Name);
            Assert.NotSame(book, book1);
        }

        [Fact]
        public void TwoVarsCanRefrenceSameObject()
        {
            var book = GetBook("Book 1");
            var book1 = book;

            Assert.Equal("Book 1", book.Name);
            Assert.Equal("Book 1", book1.Name);
            Assert.Same(book, book1);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
