using HomeWork2.Models;

public class Program
{
    public static void Main()
    {
        name:
        Console.WriteLine("Write your Name");
        string? name = Console.ReadLine();
        if (name== "")
        {
            goto name;
        }
        surename:
        Console.WriteLine("Write your Name");
        string? surename = Console.ReadLine();
        if (surename == "")
        {
            goto surename;
        }
        User user = new User(name, surename);
        
        
        

        


        Console.WriteLine($"User:{user.UserName}\nMailAdress:{user.Email} ");




    }
}