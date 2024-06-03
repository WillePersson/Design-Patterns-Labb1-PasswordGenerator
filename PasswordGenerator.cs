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
		private static readonly object lockObject = new object();

		private PasswordGenerator() { } // Private constructor

		public static PasswordGenerator Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (lockObject)
					{
						if (_instance == null)
						{
						     _instance = new PasswordGenerator(); // Creating the single instance
					        }
					}
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

			if (includeLowercase) characterSets.Add(CharacterSetFactory.CreateCharacterSet(CharacterSetType.Lowercase)); // Factory Methods
			if (includeUppercase) characterSets.Add(CharacterSetFactory.CreateCharacterSet(CharacterSetType.Uppercase)); 
			if (includeDigits) characterSets.Add(CharacterSetFactory.CreateCharacterSet(CharacterSetType.Digits));
			if (includeSpecial) characterSets.Add(CharacterSetFactory.CreateCharacterSet(CharacterSetType.Special)); 

			if (characterSets.Count == 0)
			{
				throw new ArgumentException("At least one character set must be selected.");
			}

			return _strategy.GeneratePassword(length, characterSets); // Using the strategy to generate the password
		}
	}
}
