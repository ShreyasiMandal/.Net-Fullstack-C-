using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace FileIODemo
{
    public class FileStreamDemo
    {
        FileStream fs = null;
        public void CreateFile(string fileName)
        {
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                
                sw.WriteLine("This is just a sample file for File Io Demo");
                sw = new StreamWriter(fs);
                sw.Close();
                fs.Close();
            }
            catch(FileNotFoundException e)
            { 
                System.Console.WriteLine(e.Message);
            }
            catch(FileLoadException e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        public void ReadFile(string fileName)
        {
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }
    }
}
