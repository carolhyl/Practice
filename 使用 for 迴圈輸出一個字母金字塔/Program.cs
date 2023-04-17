namespace 使用_for_迴圈輸出一個字母金字塔
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string diagramDefult = "!,@,#,$,%,^,&,*,(,),+";
			string[] diagramList = diagramDefult.Split(',');

            for (int i = 0; i < diagramList.Length; i++)
            {
                string diagram = diagramList[i];
                string space = new string(' ', (diagramList.Length - 1));
                string result = space + diagram;
                Console.WriteLine(result);

            }

        }
	}
}