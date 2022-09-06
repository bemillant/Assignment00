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

    public void isInputLeapYear(String year){
        int number;
        if (!int.TryParse(year, out number)){
            Console.WriteLine("Please enter a year!");
        }else {
            if (isLeapYear(number)){
                Console.WriteLine("Yay");
            }else{
                Console.WriteLine("Nay");
            }
        }
    }



}