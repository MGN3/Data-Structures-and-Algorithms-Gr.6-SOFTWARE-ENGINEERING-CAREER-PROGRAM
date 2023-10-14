using System.Collections;
using System.Diagnostics;

namespace SoftwareEngineerDigitalStack {
	internal class Program {
		static void Main(string[] args) {

			int[] test1 = Solution.CountBits(25);

			foreach (int i in test1) {
				Console.Write($"{i} ");
			}

			//testing FizzBuzz
			Solution.FizzBuzz(35);

			//TESTING ReverseString
			char[] test2 = { 'h', 'e', 'l', 'l', 'o' };

			Solution.ReverseString(test2);

			Console.WriteLine(test2);


			//Th
			Solution.MyIterator(50);
			foreach (int i in Solution.MyIterator(50)) {
				Console.Write($"{i} - ");
			}


			//No entiendo el metodo usado en Solution.Test1, pues devuelve un ICollection en vez de un List como está estipulado en el return.
			var prueba = Solution.Test1<long>();
			List<long> resultado = Solution.Test1<long>().ToList();
			resultado.Add(12);
			Console.WriteLine($"\n {resultado[0]}");

			string prueba1 = "hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio";
	
			string solution;

			//solution = Solution.ReverseSentence3(prueba1);

			//Console.WriteLine(solution);



			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			solution = Solution.ReverseSentence3(prueba1);
			stopwatch.Stop();

			TimeSpan tiempoTotal = stopwatch.Elapsed;
			TimeSpan tiempoInicial = stopwatch.Elapsed - tiempoTotal;
			TimeSpan tiempoFinal = stopwatch.Elapsed;

			Console.WriteLine("Tiempo inicial: {0}", tiempoInicial.ToString());
			Console.WriteLine("Tiempo final: {0}", tiempoFinal.ToString());
			Console.WriteLine("Tiempo total: {0}", tiempoTotal.ToString());



			string sentence = "hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo miohola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio hola buenos dias amigo mio";
			Stopwatch stopwatchFinal = new Stopwatch();

			// Medición del primer método
			stopwatchFinal.Start();
			Solution.ReverseSentence2(sentence);
			stopwatchFinal.Stop();
			TimeSpan tiempoPrimerMetodo = stopwatchFinal.Elapsed;

			// Medición del segundo método
			stopwatchFinal.Reset();
			stopwatchFinal.Start();
			Solution.ReverseSentence3(sentence);
			stopwatchFinal.Stop();
			TimeSpan tiempoSegundoMetodo = stopwatchFinal.Elapsed;

			if (tiempoPrimerMetodo < tiempoSegundoMetodo) {
				Console.WriteLine("El primer método es más rápido que el segundo método en un {0}%.", Math.Round((tiempoSegundoMetodo - tiempoPrimerMetodo).TotalMilliseconds / tiempoSegundoMetodo.TotalMilliseconds * 100, 2));
			} else {
				Console.WriteLine("El segundo método es más rápido que el primer método en un {0}%.", Math.Round((tiempoPrimerMetodo - tiempoSegundoMetodo).TotalMilliseconds / tiempoPrimerMetodo.TotalMilliseconds * 100, 2));
			}
			Console.WriteLine(solution);
		}

		//Given a positive integer n, write a Java program to calculate the
		//sum of all positive integers from 1 to n, inclusive.
		private int calculateSum(int n) {
			int sum = 0;
			for (int i = 1; i <= n; i++) {
			}

			return sum;
		}



	}

}