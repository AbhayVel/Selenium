using NPOI.Util.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FirstKeywordDrivenFramework
{
	
	public class ReadPropertyFile
    {
		Properties p = new Properties();
		public void OpenProperty(string path)
        {
			
			// This example will give you idea about File handling with properties 
			FileStream fs = null;
			try
			{
				fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
			}
			catch (FileNotFoundException e1)
			{
				// TODO Auto-generated catch block
				Console.WriteLine(e1.ToString());
				Console.Write(e1.StackTrace);
			}


			
			try
			{
				System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

				p.Load(fs);
				Console.WriteLine("hi");
			}
			catch (IOException e)
			{
				// TODO Auto-generated catch block
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			}
		}

		public string GetValue(string key)
        {

			return p[key].ToString(); 

        }
    }
}
