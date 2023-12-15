namespace CasualRelationships
{
	public static class Solver
	{
		private const int MaxIterationsCount = 100;

		private static double FunctionRight(double x)
		{
			return Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x - 1;
		}

		private static double FunctionWrong(double x)
		{
			return Math.Pow(x, 4) - 2 * Math.Pow(x, 3) - x - 1;
		}

		private static bool SignsAreEqual(double value1, double value2)
		{
			return value1 * value2 >= 0;
		}

		public static double? SolveRight(TestingData data)
		{
			double leftBoundary = Math.Min(data.A,data.B), rightBoundary = Math.Max(data.A, data.B);
			var e = data.Eps;

			int iterationsCount = 0;
			while (true)
			{
				iterationsCount++;

				var middle = (leftBoundary + rightBoundary) / 2;

				if (FunctionRight(middle) == 0 || Math.Abs(rightBoundary - leftBoundary) < Abs(e))
				{
					return middle;
				}

				if (SignsAreEqual(FunctionRight(middle), FunctionRight(leftBoundary)))
				{
					leftBoundary = middle;
				}
				else
				{
					rightBoundary = middle;
				}

				if (iterationsCount > MaxIterationsCount)
				{
					return null;
				}
			}
		}

		public static double? SolveWrong(TestingData data)
		{
			double leftBoundary = Math.Min(data.A, data.B), rightBoundary = Math.Max(data.A, data.B);
			var e = data.Eps;

			int iterationsCount = 0;
			while (true)
			{
				iterationsCount++;

				var middle = (leftBoundary + rightBoundary) / 2;

				if (FunctionWrong(middle) == 0 || Math.Abs(rightBoundary - leftBoundary) < Abs(e))
				{
					return middle;
				}

				if (SignsAreEqual(FunctionWrong(middle), FunctionWrong(leftBoundary)))
				{
					leftBoundary = middle;
				}
				else
				{
					rightBoundary = middle;
				}

				if (iterationsCount > MaxIterationsCount)
				{
					return null;
				}
			}
		}

		private static double? Abs(double? x)
		{
			return x >= 0 ? x : -x;
		}
	}
}
