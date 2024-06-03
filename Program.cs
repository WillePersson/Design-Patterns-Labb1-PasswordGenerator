namespace Design_Patterns_Labb1_PasswordGenerator
{
	//Singelton Pattern, Strategy Pattern, Factory Method (Wille Persson - Net23)
	internal class Program
	{
		static void Main(string[] args)
		{
			UserInterface ui = new UserInterface();
			ui.Run();
		}
	}
}
