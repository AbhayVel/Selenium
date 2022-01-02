using Microsoft.Win32.SafeHandles;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FirstKeywordDrivenFramework
{
    class Readxlxscs
    {
        XSSFWorkbook workbook = null;
        ISheet sheet = null; 


        public void OpenExcel (string path )
        {
            FileStream inputstream = null;
            try
            {
                inputstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException e)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e.ToString());
                Console.Write(e.StackTrace);
            }


           
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
        }
        public void ReadSheet(string sheetname)
        {
          sheet = workbook.GetSheet(sheetname);
        }
        public int GetRowCount()
        {
            return sheet.LastRowNum; 
        }
        public TestCases GetTestCase(int rowNumber)
        {
            
            IRow row = sheet.GetRow(rowNumber);
            TestCases testcase = new TestCases();
            testcase.TestSteps = row.GetCell(0).StringCellValue;
            testcase.LocatorType = row.GetCell(0).StringCellValue;
            testcase.LocatorTypeValue = row.GetCell(0).StringCellValue;
            testcase.Action = row.GetCell(0).StringCellValue;
            testcase.Value = row.GetCell(0).StringCellValue;
            return testcase; 

        }
        
    }
}
