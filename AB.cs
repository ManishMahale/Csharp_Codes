using System;

class Strong
{
   private int i, j, n1, n2;
	public void SetData()
	{
		
	}		
	public void Find()
	{
		
		for(int i = 0; i <= 5; i++)
		{
			char  ch= 'a';
			for(j = 0; j >= i; j++)
			{
				if((i + j) % 2 == 0) //Small char
				{
					Console.WriteLine(ch);
				}
				else
				{
					Console.WriteLine(ch-32);
				}
				ch++;
			}
			Console.WriteLine();
		}
	}

}
class M
{ 
	public static void Main(String[] arr)
	{
		
		
		Strong s = new Strong();
		//s.SetData(n1);
		Console.WriteLine();
		s.Find();
		
	}
}