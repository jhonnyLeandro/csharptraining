using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void StringBehavesLikeValueTypes()
        {
            string name = "Scott";
            string upper = MakeUpperCase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUpperCase(string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void test2()
        {
            var x = GetInt();
            SetInt(out x);
            Assert.Equal(42,x);
        }
        

        private void SetInt( out int x){
            x = 42;
        }

        private int GetInt(){
            return 3;
        }

        [Fact]
        public void CSharpCAnPassByREf()
        {
            var book = GetBook("Book 1");
            GetBookSetName(ref book, "New name");

            Assert.Equal("New name", book.Name);
        }

        private void GetBookSetName(ref Book book, string name){
            book = new Book(name);
        }



        [Fact]
        public void CSharpIsPassByValue()
        {
            var book = GetBook("Book 1");
            GetBookSetName(book, "New name");

            Assert.Equal("Book 1", book.Name);
        }

        private void GetBookSetName(Book book, string name){
            book = new Book(name);
        }

        [Fact]
        public void test1()
        {
            var book = GetBook("Book 1");
            SetName(book, "New name");

            Assert.Equal("New name", book.Name);
        }

        private void SetName(Book book, string name){
            book.Name = name;
        }

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
