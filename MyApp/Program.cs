// See https://aka.ms/new-console-template for more information
namespace MyApp;

public class Program{
    public static void Main(String[] args){
        Year y = new Year();
        Console.WriteLine("Hello, World!");
        Console.WriteLine(y.isLeapYear(8));
        Console.WriteLine("Enter a year to see if it is a leap year!");
        string input = Console.ReadLine();
        y.isInputLeapYear(input);

    }
}