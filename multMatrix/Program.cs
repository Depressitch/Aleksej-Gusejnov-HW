using System;

public static class Program
{
	public static void Main()
	{
		Console.Write("Input sizes of first matrix (a - height, b - width):\na: ");
		int a = Parse.IntValue();
		Console.Write("b: ");
		int b = Parse.IntValue();
		int[,] mtrOne = new int[a, b];
		mtrOne = Matrix.GetRand(mtrOne);
		Console.WriteLine("====================\n" + "Matrix one: ");
		Matrix.Output(mtrOne);

		Console.WriteLine("====================");
		Console.Write("Input sizes of second matrix (a - height, b - width):\na: ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b: ");
		b = Convert.ToInt32(Console.ReadLine());
		int[,] mtrTwo = new int[a, b];
		mtrTwo = Matrix.GetRand(mtrTwo);
		Console.WriteLine("====================\n" + "Matrix two: ");
		Matrix.Output(mtrTwo);

		Console.WriteLine("====================\n" + "Result of multiplied matrixes: ");
		Matrix.Output(Matrix.Multiply(mtrOne, mtrTwo));
		AddCmd.Repeat('r');
	}
}
