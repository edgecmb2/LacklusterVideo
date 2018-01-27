using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace MovieRentals
{
	public partial class ExcelWrapper
	{
		public partial class Workbook : IDisposable
		{
			// ************************************************************************
			// ************************************************************************
			private string fileName;
			private Excel.Application app = new Excel.Application();
			private Excel.Workbook book;
			private Dictionary<string, Worksheet> usedSheets = new Dictionary<string, Worksheet>();			


			// ************************************************************************
			// ************************************************************************
			public Workbook(string fileName)
			{
				this.fileName = fileName;
				app.DisplayAlerts = false;
				Excel.Worksheet sheet;

				book = app.Workbooks.Add();

				for (int i = book.Sheets.Count; i > 1; i--)
				{
					sheet = (Excel.Worksheet)book.Sheets[i];
					sheet.Delete();
				}

				sheet = (Excel.Worksheet)book.Sheets[1];
				sheet.Name = "TempNameToDelete";
				usedSheets.Add("TempNameToDelete", new Worksheet(this, sheet));
			}


			// ************************************************************************
			// ************************************************************************
			public Worksheet this[string sheetName]
			{
				get
				{
					if (!usedSheets.ContainsKey(sheetName))
					{
						usedSheets.Add(sheetName, new Worksheet(this, sheetName));
					}

					return usedSheets[sheetName];
				}
			}


			// ************************************************************************
			// ************************************************************************
			void IDisposable.Dispose()
			{
				if (book.Sheets.Count > 1)
				{
					Excel.Worksheet sheet = (Excel.Worksheet)book.Sheets["TempNameToDelete"];
					sheet.Delete();
				}

				book.SaveAs(fileName);
				book.Close();
				app.Quit();
			}


			// ************************************************************************
			// ************************************************************************
			public class Worksheet
			{
				// ************************************************************************
				// ************************************************************************
				private Workbook book;
				private Excel.Worksheet sheet;


				// ************************************************************************
				// ************************************************************************
				public Worksheet(Workbook book, string sheetName)
				{
					this.book = book;

					Excel.Worksheet lastSheet = (Excel.Worksheet)book.book.Sheets["TempNameToDelete"];
					sheet = (Excel.Worksheet)book.book.Sheets.Add(Before: lastSheet);
					sheet.Name = sheetName;
				}


				// ************************************************************************
				// ************************************************************************
				public Worksheet(Workbook book, Excel.Worksheet sheet)
				{
					this.sheet = sheet;
				}


				// ************************************************************************
				// ************************************************************************
				public Excel.Range Cell(int row, int col)
				{
					return (Excel.Range)sheet.Cells[row, col];
				}


				// ************************************************************************
				// ************************************************************************
				public Excel.Range Cell(int row, string col)
				{
					return (Excel.Range)sheet.Cells[row, col];
				}


				// ************************************************************************
				// ************************************************************************
				public Excel.Range Range(Excel.Range startCell, Excel.Range endCell)
				{
					return sheet.get_Range(startCell, endCell);
				}
			}
		}
	}
}
