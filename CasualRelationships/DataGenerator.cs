namespace CasualRelationships
{
	public static class DataGenerator
	{
		public const int TestsCount = 2;
		private const int MinInt = -20, MaxInt = 20;
		private static readonly Random GRandom = new();

		public static List<TestingData> GenerateData()
		{
			return new()
			{
				GenerateRightData(),
				GenerateWrongData()
			};
		}

		private static TestingData GenerateRightData()
		{
			return new(RandInt(), RandInt(), GRandom.NextDouble());
		}	

		private static TestingData GenerateWrongData()
		{
			return new(RandInt(), RandInt(), null);
		}

		private static int RandInt()
		{
			return GRandom.Next(MinInt, MaxInt);
		}
	}
}
