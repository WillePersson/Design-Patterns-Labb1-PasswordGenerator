using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Labb1_PasswordGenerator
{
	public class RandomPasswordStrategy : IPasswordStrategy // Implementing IPasswordStrategy
	{
		public string GeneratePassword(int length, List<ICharacterSet> characterSets)
		{
			StringBuilder characterSet = new StringBuilder();
			foreach (var set in characterSets)
			{
				characterSet.Append(set.GetCharacters());
			}

			StringBuilder password = new StringBuilder();
			Random random = new Random();

			for (int i = 0; i < length; i++)
			{
				int index = random.Next(characterSet.Length);
				password.Append(characterSet[index]);
			}

			return password.ToString();
		}
	}
}
