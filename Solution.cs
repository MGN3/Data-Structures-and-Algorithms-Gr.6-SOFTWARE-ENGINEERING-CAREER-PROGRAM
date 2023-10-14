using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineerDigitalStack {
	public class Solution {
		public static int[] CountBits(int n) {
			int[] result = new int[n + 1];

			for (int i = 1; i <= n; i++) {
				// La cantidad de 1's en i se puede calcular de la siguiente manera:
				// 1. Tome el resultado para (i >> 1), que es la mitad de i.
				// 2. Luego, sume 1 si i es impar (es decir, si el bit menos significativo es 1).
				// Esto se debe a que el bit menos significativo de i es 1 si i es impar y 0 si es par.
				result[i] = result[i >> 1] + (i & 1);
			}

			return result;
		}

		public static void FizzBuzz(int n) {
			if (n <= 0) {
				Console.WriteLine("Introduce a positive number");
			} else {
				for (int i = 1; i <= n; i++) {
					if (i % 3 == 0 && i % 5 == 0) {
						Console.WriteLine("FizzBuzz");
					} else if (i % 3 == 0) {
						Console.WriteLine("Fizz");
					} else if (i % 5 == 0) {
						Console.WriteLine("Buzz");
					} else {
						Console.WriteLine(i);
					}
				}
			}
		}

		//Given an integer array nums, return true if any value appears at
		//least twice in the array, and return false if every element is
		//distinct.
		public static bool ContainsDuplicate(int[] nums) {
			bool isAnyValueRepeated = false;

			for (int i = 0; i <= nums.Length - 1; i++) {
				for (int j = i; j <= nums.Length; j++) {
					if (nums[i] == nums[j]) {
						isAnyValueRepeated = true;
					}
				}
			}
			return isAnyValueRepeated;
		}
		//swapping technique
		public static char[] ReverseString(char[] s) {
			int i = 0;
			int j = s.Length - 1;
			char tmp;

			while (i < j) {
				tmp = s[i];
				s[i] = s[j];
				s[j] = tmp;

				i++;
				j--;
			}
			return s;
		}

		/// <summary>
		/// This is the a test method to apply IEnumerable
		/// </summary>
		/// <param name="iterations"></param>
		/// <returns>An IEnumerable with the value of i until it iterates all the times required</returns>
		public static IEnumerable<int> MyIterator(int iterations) {
			for (int i = 0; i < iterations; i++) {
				yield return i;
			}
		}

		/// <summary>
		/// This is a test method to apply IEnumerable instead of the Iterator from Java
		/// </summary>
		/// <param name="iterations"></param>
		/// <returns>A specific set of constant values in the form of an IEnumerable</returns>
		public static IEnumerable<int> MyIterator() {
			yield return 1;
			yield return 2;
			yield return 3;
			yield return 4;
			yield return 5;
			yield return 6;
			yield return 7;
			yield return 8;
			yield return 9;
		}
		/// <summary>
		/// For some reason, even when I instantiate a List<T>, the returned Object/data structure is the ICollection.
		/// One possible explanation is that the compiler converts the List back to an ICollection since its statec in the method header.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static ICollection<T> Test1<T>() {
			// Crea una instancia de una clase concreta que implementa ICollection<T>
			return new List<T>(); // Por ejemplo, puedes usar List<T> como implementación
		}

		/*
		 * Given an input string s, reverse the order of the words.
			A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
			Return a string of the words in reverse order concatenated by a single space.
			Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.

			Hola buenos dias
		 * */
		public static string ReverseSentence(string sentence) {
			int sentenceLength;
			string newSentence = string.Empty;

			if (!string.IsNullOrEmpty(sentence)) {

				sentenceLength = sentence.Length;

				for (int i = sentenceLength - 1; i >= 0; i--) {
					if (sentence[i] == ' ') {
						newSentence += sentence.Substring(i + 1, sentenceLength - i - 1) + " ";
						sentenceLength = i;
					}
				}
				newSentence += sentence.Substring(0, sentenceLength);
			}

			return newSentence;
		}

		public static string ReverseSentence2(string sentence) {

			int sentenceLength;

			string[] newSentence = sentence.Split(' ');
			System.Text.StringBuilder newSentenceBuilder = new System.Text.StringBuilder();

			if (!string.IsNullOrEmpty(sentence)) {

				sentenceLength = newSentence.Length;

				for (int i = sentenceLength - 1; i >= 0; i--) {
					newSentenceBuilder.Append(newSentence[i]);
					if (i > 0) {
						newSentenceBuilder.Append(" ");
					}
				}
			}
			return newSentenceBuilder.ToString();
		}



		public static string ReverseSentence3(string sentence) {

			int sentenceLength;
			string newSentence = string.Empty;

			if (!string.IsNullOrEmpty(sentence)) {
				
				string[] words = sentence.Split(' ');
				Console.WriteLine(words.Length);
				List<string> reversedWords = new List<string>();

				sentenceLength = words.Length;

				for (int i = words.Length - 1; i >= 0; i--) {
					reversedWords.Add(words[i]);
				}
				newSentence = string.Join(" ", reversedWords);
			}

			return newSentence;
		}

		//https://leetcode.com/problems/first-bad-version/
		public int FirstBadVersion(int n) {
			int left = 1;
			int right = n;
			while (left < right) {
				int mid = (left + right) / 2;
				//Change for the code bellow to make if better/correct/acceptable?
				//int mid = left + (right-left)/2;
				if(IsBadVersion(mid)) {
					right = mid;
				} else {
					left = mid + 1;
				}
			}
			return right;
			}


		
	}
}
