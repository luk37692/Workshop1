using UpperCaseConversion.ViewModel;

namespace UpperCaseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var viewModel = new MainViewModel();
            while (true)
            {
                Console.WriteLine("Enter a string to convert to uppercase (or type '0' to quit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "0")
                {
                    break;
                }

                string upperCaseString = viewModel.GetUpperCaseString(input);
                Console.WriteLine($"Uppercase: {upperCaseString}");
            }
        }
    }
}
