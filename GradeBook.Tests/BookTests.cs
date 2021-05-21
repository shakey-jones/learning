using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);


        }

        [Fact]
        public void BookAddsValidValues()
        {
            // arrange
            var book = new Book("Value Test");
            book.AddGrade(105);

            // act
            var result = book.grades[0];

            // assert
            Assert.Equal(105, result, 1);


        }
 
    }
}
