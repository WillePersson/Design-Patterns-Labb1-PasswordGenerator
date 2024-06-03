using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb1_PasswordGenerator
{
	// Singleton Pattern
	public class PasswordGenerator
	{
		private static PasswordGenerator _instance; // Single instance
		private IPasswordStrategy _strategy; // Strategy pattern interface

		private PasswordGenerator() { } // Private constructor

		public static PasswordGenerator Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new PasswordGenerator(); // Creating the single instance
				}
				return _instance;
			}
		}

		public void SetStrategy(IPasswordStrategy strategy) // Strategy Pattern
		{
			_strategy = strategy; // Setting the strategy
		}

		public string GeneratePassword(int length, bool includeLowercase, bool includeUppercase, bool includeDigits, bool includeSpecial)
		{
			List<ICharacterSet> characterSets = new List<ICharacterSet>();

			if (includeLowercase) characterSets.Add(CharacterSetFactory.CreateCharacterSet(CharacterSetType.Lowercase)); // Factory Method
			if (includeUppercase) characterSets.Add(CharacterSetFactory.CreateCharacterSet(CharacterSetType.Uppercase)); // Factory Method
			if (includeDigits) characterSets.Add(CharacterSetFactory.CreateCharacterSet(CharacterSetType.Digits)); // Factory Method
			if (includeSpecial) characterSets.Add(CharacterSetFactory.CreateCharacterSet(CharacterSetType.Special)); // Factory Method

			if (characterSets.Count == 0)
			{
				throw new ArgumentException("At least one character set must be selected.");
			}

			return _strategy.GeneratePassword(length, characterSets); // Using the strategy to generate the password
		}
	}
}
