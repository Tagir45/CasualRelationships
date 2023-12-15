namespace CasualRelationships
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TaskPage = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SchemaPage = new System.Windows.Forms.TabPage();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.DiagramPage = new System.Windows.Forms.TabPage();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.TablePage = new System.Windows.Forms.TabPage();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.TestingPage = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.NumberColumn = new System.Windows.Forms.ColumnHeader();
			this.AColumn = new System.Windows.Forms.ColumnHeader();
			this.BColumn = new System.Windows.Forms.ColumnHeader();
			this.EColumn = new System.Windows.Forms.ColumnHeader();
			this.ExpectedColumn = new System.Windows.Forms.ColumnHeader();
			this.RealColumn = new System.Windows.Forms.ColumnHeader();
			this.SuccessColumn = new System.Windows.Forms.ColumnHeader();
			this.CountLabel = new System.Windows.Forms.Label();
			this.TestingButton = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.TaskPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SchemaPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.DiagramPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.TablePage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.TestingPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TaskPage);
			this.tabControl1.Controls.Add(this.SchemaPage);
			this.tabControl1.Controls.Add(this.DiagramPage);
			this.tabControl1.Controls.Add(this.TablePage);
			this.tabControl1.Controls.Add(this.TestingPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1226, 866);
			this.tabControl1.TabIndex = 0;
			// 
			// TaskPage
			// 
			this.TaskPage.Controls.Add(this.pictureBox1);
			this.TaskPage.Location = new System.Drawing.Point(4, 32);
			this.TaskPage.Name = "TaskPage";
			this.TaskPage.Padding = new System.Windows.Forms.Padding(3);
			this.TaskPage.Size = new System.Drawing.Size(1218, 830);
			this.TaskPage.TabIndex = 0;
			this.TaskPage.Text = "Постановка задачи";
			this.TaskPage.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1206, 818);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// SchemaPage
			// 
			this.SchemaPage.Controls.Add(this.pictureBox2);
			this.SchemaPage.Location = new System.Drawing.Point(4, 30);
			this.SchemaPage.Name = "SchemaPage";
			this.SchemaPage.Size = new System.Drawing.Size(1218, 832);
			this.SchemaPage.TabIndex = 4;
			this.SchemaPage.Text = "Блок-схема алгоритма";
			this.SchemaPage.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1212, 825);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// DiagramPage
			// 
			this.DiagramPage.Controls.Add(this.pictureBox3);
			this.DiagramPage.Location = new System.Drawing.Point(4, 30);
			this.DiagramPage.Name = "DiagramPage";
			this.DiagramPage.Padding = new System.Windows.Forms.Padding(3);
			this.DiagramPage.Size = new System.Drawing.Size(1218, 832);
			this.DiagramPage.TabIndex = 1;
			this.DiagramPage.Text = "Диаграмма причинно-следственных связей";
			this.DiagramPage.UseVisualStyleBackColor = true;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(6, 6);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(1206, 818);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// TablePage
			// 
			this.TablePage.Controls.Add(this.pictureBox4);
			this.TablePage.Location = new System.Drawing.Point(4, 30);
			this.TablePage.Name = "TablePage";
			this.TablePage.Size = new System.Drawing.Size(1218, 832);
			this.TablePage.TabIndex = 3;
			this.TablePage.Text = "Таблица решений";
			this.TablePage.UseVisualStyleBackColor = true;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(3, 3);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(1212, 824);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// TestingPage
			// 
			this.TestingPage.Controls.Add(this.listView1);
			this.TestingPage.Controls.Add(this.CountLabel);
			this.TestingPage.Controls.Add(this.TestingButton);
			this.TestingPage.Location = new System.Drawing.Point(4, 32);
			this.TestingPage.Name = "TestingPage";
			this.TestingPage.Size = new System.Drawing.Size(1218, 830);
			this.TestingPage.TabIndex = 2;
			this.TestingPage.Text = "Тестирование";
			this.TestingPage.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumn,
            this.AColumn,
            this.BColumn,
            this.EColumn,
            this.ExpectedColumn,
            this.RealColumn,
            this.SuccessColumn});
			this.listView1.Location = new System.Drawing.Point(3, 227);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1212, 301);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// NumberColumn
			// 
			this.NumberColumn.Text = "Номер теста";
			// 
			// AColumn
			// 
			this.AColumn.Text = "A";
			// 
			// BColumn
			// 
			this.BColumn.Text = "B";
			// 
			// EColumn
			// 
			this.EColumn.Text = "E";
			// 
			// ExpectedColumn
			// 
			this.ExpectedColumn.Text = "Ожидаемое значение";
			// 
			// RealColumn
			// 
			this.RealColumn.Text = "Фактическое значение";
			// 
			// SuccessColumn
			// 
			this.SuccessColumn.Text = "Результат тестирования";
			// 
			// CountLabel
			// 
			this.CountLabel.AutoSize = true;
			this.CountLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CountLabel.Location = new System.Drawing.Point(437, 71);
			this.CountLabel.Name = "CountLabel";
			this.CountLabel.Size = new System.Drawing.Size(218, 31);
			this.CountLabel.TabIndex = 1;
			this.CountLabel.Text = "Количество тестов: ";
			// 
			// TestingButton
			// 
			this.TestingButton.Location = new System.Drawing.Point(451, 128);
			this.TestingButton.Name = "TestingButton";
			this.TestingButton.Size = new System.Drawing.Size(204, 68);
			this.TestingButton.TabIndex = 0;
			this.TestingButton.Text = "Тестировать";
			this.TestingButton.UseVisualStyleBackColor = true;
			this.TestingButton.Click += new System.EventHandler(this.TestingButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.OldLace;
			this.ClientSize = new System.Drawing.Size(1264, 884);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Лабораторная работа №5";
			this.tabControl1.ResumeLayout(false);
			this.TaskPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.SchemaPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.DiagramPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.TablePage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.TestingPage.ResumeLayout(false);
			this.TestingPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControl1;
		private TabPage TaskPage;
		private TabPage DiagramPage;
		private TabPage TestingPage;
		private PictureBox pictureBox1;
		private Label CountLabel;
		private Button TestingButton;
		private ListView listView1;
		private ColumnHeader EColumn;
		private ColumnHeader ExpectedColumn;
		private ColumnHeader RealColumn;
		private ColumnHeader SuccessColumn;
		private ColumnHeader NumberColumn;
		private TabPage TablePage;
		private TabPage SchemaPage;
		private PictureBox pictureBox2;
		private ColumnHeader AColumn;
		private ColumnHeader BColumn;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
	}
}