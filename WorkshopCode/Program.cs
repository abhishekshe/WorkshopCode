using System;

namespace workshopDemo
{
	public class Anargam
	{

		static int limit_Of_Word = 500;

		
		static bool areAnagram(char[] str1, char[] str2)
		{
			
			int[] count1 = new int[limit_Of_Word];
			int[] count2 = new int[limit_Of_Word];
			

			
			for (int i = 0; i < str1.Length && i < str2.Length; i++)
			{
				count1[str1[i]]++;
				count2[str2[i]]++;
			}

			
			if (str1.Length != str2.Length)
				return false;

			
			for (int i = 0; i < limit_Of_Word; i++)
			{
				if (count1[i] != count2[i])
					return false;
			}
            
				
			return true;
		}

		
		public static void Main()
		{
			char[] str1 = ("earth").ToCharArray();
			char[] str2 = ("heart").ToCharArray();

			
			if (areAnagram(str1, str2))
				Console.WriteLine("The two strings are"
								+ " anagram");
			else
				Console.WriteLine("The two strings are not"
								+ " anagram");
		}
	}

}




