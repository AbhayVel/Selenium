using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NUnit.Framework;
using System;
using System.IO;

namespace com.refer
{


 

	public class Selenium_Example043_ReadDataFromxls_XSSFFormat
	{

		[Test]
			public  void Main(string[] args)
			{


				string excelpath = "D:\\Amruta\\Testexcelprogram.xlsx";
				FileStream inputstream = null;
				try
				{
					inputstream = new FileStream(excelpath, FileMode.Open, FileAccess.Read);
				}
				catch (FileNotFoundException e)
				{
					// TODO Auto-generated catch block
					Console.WriteLine(e.ToString());
					Console.Write(e.StackTrace);
				}


				XSSFWorkbook workbook = null;
				try
				{
					workbook = new XSSFWorkbook(inputstream);
				}
				catch (IOException e)
				{
					// TODO Auto-generated catch block
					Console.WriteLine(e.ToString());
					Console.Write(e.StackTrace);
				}
				ISheet sheet = workbook.GetSheet("Sheet1");

				// Using for loop

				int rows = sheet.LastRowNum;
				int cols = sheet.GetRow(1).LastCellNum;

				for (int r = 0; r < rows; r++)
				{

					IRow row = sheet.GetRow(r);

					for (int c = 0; c < cols; c++)
					{

						ICell cell = row.GetCell(c);
						switch (cell.CellType)
						{
						case CellType.String:
							Console.Write(cell.StringCellValue + "\t");
						break;
						case CellType.Numeric:
							Console.Write(cell.NumericCellValue + "\t");
							break;
						case CellType.Boolean:
							Console.Write(cell.BooleanCellValue + "\t");
							break;

						}

					}

					Console.WriteLine();
				}

			}
	}



}