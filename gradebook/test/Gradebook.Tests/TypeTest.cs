using System;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
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
        public void CanBookSetName(ref Book book, string name)
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
