using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 整數陣列出現頻率最高的數字
{
	internal class Program
	{
		static void Main(string[] args)
		{
           Dictionary<int,int> frequency = new Dictionary<int,int>();
			int[] numbers = new int[] { 1, 2, 3, 3, 4, 5, 6, 6, 6, 9 };

			foreach (int num in numbers)
			{
				if (frequency.ContainsKey(num))
				{ frequency[num]++; }
				else  frequency.Add(num, 1);
			}

		}


	}
}
