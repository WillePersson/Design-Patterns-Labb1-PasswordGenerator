using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb1_PasswordGenerator
{
	public enum CharacterSetType
	{
		Lowercase,
		Uppercase,
		Digits,
		Special
	}

	public static class CharacterSetFactory
	{
		public static ICharacterSet CreateCharacterSet(CharacterSetType type) // Factory Method Pattern
		{
			return type switch
			{
				CharacterSetType.Lowercase => new LowercaseCharacterSet(), // Creating a LowercaseCharacterSet
				CharacterSetType.Uppercase => new UppercaseCharacterSet(), // Creating an UppercaseCharacterSet
				CharacterSetType.Digits => new DigitsCharacterSet(), // Creating a DigitsCharacterSet
				CharacterSetType.Special => new SpecialCharacterSet(), // Creating a SpecialCharacterSet
				_ => throw new ArgumentException("Invalid character set type."),
			};
		}
	}
}
