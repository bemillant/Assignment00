namespace MyApp.Tests;


public class YearTests
{
    [Fact]
    public void calculating_If_LeapYear_True()
    {
        // Arrange
        var year = new Year();

        // Act
        var result = year.isLeapYear(2016);
       
        // Assert
        result.Should().Be(true);

        
    }

    [Fact]
    public void calculating_If_LeapYear_False()
    {
        // Arrange
         var year = new Year();

        // Act
         var result = year.isLeapYear(2015);
       
        // Assert
         result.Should().Be(false);
    }

    [Fact]
    public void is_Input_Within_Range_Yes()
    {
        // Arrange
         var year = new Year();

        // Act
         var result = year.isLeapYearWithinRange(2020);
       
        // Assert
         result.Should().Be(true);
    }

    [Fact]
    public void is_Input_Within_Range_No()
    {
        // Arrange
         var year = new Year();

        // Act
         var result = year.isLeapYearWithinRange(4);
       
        // Assert
         result.Should().Be(false);
    }

    [Fact]
    public void is_Input_Within_Range_No_And_Prints()
    {
        // Arrange
         var year = new Year();
         using var writer = new StringWriter();
         Console.SetOut(writer);

        // Act
         year.isInputLeapYear("4");

        // Assert
         var output = writer.GetStringBuilder().ToString().TrimEnd();
         output.Should().Be("Please enter a year after 1582, to check if the year is a leap year!");
    }





    [Fact]
    public void check_if_output_is_yay()
    {   // Arrange
         var year = new Year();
         using var writer = new StringWriter();
         Console.SetOut(writer);

        // Act
         year.isInputLeapYear("2020");

        // Assert
         var output = writer.GetStringBuilder().ToString().TrimEnd();
         output.Should().Be("Yay");
    }

    [Fact]
    public void check_if_output_is_nay()
    {   // Arrange
         var year = new Year();
         using var writer = new StringWriter();
         Console.SetOut(writer);

        // Act
         year.isInputLeapYear("1999");

        // Assert
         var output = writer.GetStringBuilder().ToString().TrimEnd();
         output.Should().Be("Nay");
    }

    [Fact]
    public void check_if_output_is_valid()
    {   // Arrange
         var year = new Year();
         using var writer = new StringWriter();
         Console.SetOut(writer);

        // Act
         year.isInputLeapYear("a");

        // Assert
         var output = writer.GetStringBuilder().ToString().TrimEnd();
         output.Should().Be("Please enter a year! (That is a year as a single number higher than 1581)");
    }


}