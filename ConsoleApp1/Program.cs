// See https://aka.ms/new-console-template for more information
using Figgle;


namespace MyConsoleApp;

public class App
{
    static void Main(string[] args)
    {
        Console.WriteLine(FiggleFonts.Standard.Render("Hello, World!!"));
    }
    public bool IsPositive(int number)
    {
        return number > 0;
    }
}