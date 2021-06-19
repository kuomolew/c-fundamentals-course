using System;
using Xunit;

namespace Gradebook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage;
            log += IncrementCount;
            var result = log("Hello!");

            Assert.Equal(3, count);
        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }
        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            string upper = MakeUppercase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void IntegerTest()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CanSetNameFromReferenceOrValue()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            CanBookSetName(ref book1, "Another Name");

            Assert.Equal("Another Name", book1.Name);
        }
        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        void CanBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void GetbookReturnsDifferentObjects()
        {
            // arrange
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            //act



            // assert
            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);

        }

        [Fact]
        public void TwoVarsCanReferenceSameObj()
        {
            // arrange
            var book1 = GetBook("Book1");
            var book2 = book1;

            //act



            // assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
