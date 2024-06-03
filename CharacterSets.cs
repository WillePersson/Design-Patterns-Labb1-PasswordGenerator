using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb1_PasswordGenerator
{
	public class LowercaseCharacterSet : ICharacterSet // Implementing ICharacterSet
	{
		public string GetCharacters()
		{
			return "abcdefghijklmnopqrstuvwxyz";
		}
	}

	public class UppercaseCharacterSet : ICharacterSet // Implementing ICharacterSet
	{
		public string GetCharacters()
		{
			return "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		}
	}

	public class DigitsCharacterSet : ICharacterSet // Implementing ICharacterSet
	{
		public string GetCharacters()
		{
			return "0123456789";
		}
	}

	public class SpecialCharacterSet : ICharacterSet // Implementing ICharacterSet
	{
		public string GetCharacters()
		{
			return "!@#$%^&*()-_=+<>?";
		}
	}
}
