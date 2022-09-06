namespace MyApp;


public class Year{


    public bool isLeapYear(int year){
            if (year % 4 == 0 ){
                if (year % 400 == 0){
                    return true;
                } else if(year % 100 == 0){
                    return false;
                } else {
                    return true;
                }
            }else{
                return false;
            }
    }

    public bool isLeapYearWithinRange(int year){
         if (year < 1582){
            return false;
        }else return true;
    }

    public void isInputLeapYear(String year){
        int number;
        if (!int.TryParse(year, out number)){
            Console.WriteLine("Please enter a year! (That is, a year as a single number higher than 1581)");
        }else {
            if (isLeapYear(number) && isLeapYearWithinRange(number)){
                Console.WriteLine("Yay");
            }else if(isLeapYearWithinRange(number)){
                Console.WriteLine("Nay");
            }else if(!isLeapYearWithinRange(number)){
                Console.WriteLine("Please enter a year after 1582, to check if the year is a leap year!");
            }
        }
    }



}