namespace 計算線段長度
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.Write("請輸入任意兩點座標A&B:");
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
            lineLength.GetLength(a, b);
		}
	}
	static class lineLength
	{
        public static int start { get; set; }
        public static int end { get; set; }

		public static void GetLength(this int start, int end)
		{
			if (start < end)
			{ int result = end - start; Console.WriteLine(result); }
			if (end < start)
			{ int result1 = start - end; Console.WriteLine(result1); }

		
		}
    }
		
}
