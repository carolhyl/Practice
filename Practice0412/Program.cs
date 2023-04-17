using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using System.Transactions;

namespace Practice0412
{
	internal class Program
	{
		static void Main(string[] args)
		{
			AreUTriangle.Calculate(6, 5, 9);
		}
	}
	static class AreUTriangle
	{
        public static int A { get; set; }
        public static int B { get; set; }
		public static int C { get; set; }
		
		public static int MaxA()
		{
			Math.Max(A, Math.Max(B, C));
			return A;
		}
		public static int MaxB()
		{
			Math.Max(B, Math.Max(A, C));
			return B;
		}
		public static int MaxC()
		{
			Math.Max(C, Math.Max(B, A));
			return A;
		}

		public static void Calculate( this int A, int B, int C) { 

			if ( MaxA() < B + C || MaxB() < A + C || MaxC() < A + B) { Console.WriteLine("可以建立三角形"); }
			else { Console.WriteLine("無法組成三角形"); }
			
		}
    }
}