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
    public void check_if_output_is_yay()
    {   // Arrange
         var year = new Year();
         using var writer = new StringWriter();
         Console.SetOut(writer);

        // Act
         year.isInputLeapYear("4");

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
         year.isInputLeapYear("19");

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
         output.Should().Be("Please enter a year!");
    }
}