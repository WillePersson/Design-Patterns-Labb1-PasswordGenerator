using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb1_PasswordGenerator
{
	public interface ICharacterSet
	{
		// Factory Method Pattern
		string GetCharacters();
	}
}
