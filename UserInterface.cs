using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb1_PasswordGenerator
{
	public class UserInterface
	{
		public void Run()
		{
			bool continueGenerating = true;

			while (continueGenerating)
			{
				Console.Clear();

				Console.WriteLine("Welcome to the Password Generator!");

				Console.Write("Enter the length of the password: ");
				int length = int.Parse(Console.ReadLine());

				Console.Write("Include lowercase letters? (y/n): ");
				bool includeLowercase = Console.ReadLine().ToLower() == "y";

				Console.Write("Include uppercase letters? (y/n): ");
				bool includeUppercase = Console.ReadLine().ToLower() == "y";

				Console.Write("Include digits? (y/n): ");
				bool includeDigits = Console.ReadLine().ToLower() == "y";

				Console.Write("Include special characters? (y/n): ");
				bool includeSpecial = Console.ReadLine().ToLower() == "y";

				// Singleton Pattern: Getting the single instance of PasswordGenerator
				PasswordGenerator generator = PasswordGenerator.Instance;

				// Strategy Pattern: Setting the password generation strategy
				generator.SetStrategy(new RandomPasswordStrategy());

				// Using the PasswordGenerator instance to generate the password
				string password = generator.GeneratePassword(length, includeLowercase, includeUppercase, includeDigits, includeSpecial);

				Console.WriteLine($"Generated Password: {password}");

				Console.Write("Would you like to generate another password? (y/n): ");
				continueGenerating = Console.ReadLine().ToLower() == "y";
			}
		}
	}
}
