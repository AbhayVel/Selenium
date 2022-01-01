using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.IO;

namespace FirstKeywordDrivenFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read excel file and print in console

            string excelpath = @"C:\Users\sajag.karki\Documents\SeleniumPractice\TestData.xlsx";
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
            ISheet sheet = workbook.GetSheet("OrangeHRM");

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
                Console.WriteLine(" ");// Check notes to write proper spacing and formating output
            }
        }
    }
}
