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
            MyDriver myDriver = new MyDriver();
            Readxlxscs rd = new Readxlxscs();

            rd.OpenExcel(@"D:\Amruta\TestData.xlsx");
            rd.ReadSheet("sheet1");



            var lstTestCases = rd.GetTestCases();
            for (int i = 0; i < lstTestCases.Count; i++)
            {
                myDriver.Exceute(lstTestCases[i]);
            }
             
        }
    }
}
