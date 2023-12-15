namespace CasualRelationships
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			foreach (ColumnHeader header in listView1.Columns)
			{
				header.Width = listView1.Width / listView1.Columns.Count;
			}

			CountLabel.Text += DataGenerator.TestsCount.ToString();
		}

		private void TestingButton_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();

			Test();
		}

		private void Test()
		{
			var results = Tester.Test();

			FillTable(results);
		}

		private void FillTable(List<TestingResult> results)
		{
			for (int i = 0; i < results.Count; i++)
			{
				var result = results[i];

				ListViewItem item = new($"{i + 1}");
				item.SubItems.Add(result.A.ToString());
				item.SubItems.Add(result.B.ToString());
				item.SubItems.Add(result.E.ToString());
				item.SubItems.Add(result.ExpectedResult.ToString());
				item.SubItems.Add(result.RealResult.ToString());
				item.SubItems.Add(result.Successful ? "Успешно" : "Неудачно");

				listView1.Items.Add(item);
			}
		}
	}
}