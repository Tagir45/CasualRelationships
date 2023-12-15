namespace CasualRelationships
{
	public static class Tester
	{
		public static List<TestingResult> Test()
		{
			var results = new List<TestingResult>();

			foreach (var data in DataGenerator.GenerateData())
			{
				var expected = Solver.SolveRight(data);
				var real = Solver.SolveWrong(data);

				results.Add(new(data.A, data.B, data.Eps, expected, real, expected != real));
			}

			return results;
		}
	}
}
