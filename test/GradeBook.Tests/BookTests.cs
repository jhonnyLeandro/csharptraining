using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            var book = new Book("Jhonny");
            book.addGrade(89.1);
            book.addGrade(90.5);
            book.addGrade(77.3);

            var result = book.getStatistics();

            Assert.Equal(85.6, result.average, 1);
            Assert.Equal(90.5, result.high);
            Assert.Equal(77.3, result.low);
        }
    }
}
