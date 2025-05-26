using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp1.Lib
{
    public class FileManager
    {
        public string path;
        internal string logEntry;
        public FileManager(String path1) 
        {
            this.path = path1;
            this.logEntry = "FM: FILE: " + path1 + " ";
        }

        public void createFile(String text)
        {
            using (FileStream fs = File.Create(this.path, 1024))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(text);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
       //     new logs(logEntry + " created.", false, 0);
        }

        public void writeFile(String content)
        {
            StreamWriter sw = new StreamWriter(this.path);
            //Write a line of text
            sw.WriteLine(content);
            
            sw.Close();
           // new logs(logEntry + " written.", false, 0);
        }

        public string getFirsLine()
        {
            StreamReader sr = new StreamReader(this.path);
            //Read the first line of text
            String line = sr.ReadLine().ToString();
            sr.Close();
            return line;
        }

        public string getFileText()
        {
            StreamReader sr = new StreamReader(this.path);
            String dd = sr.ReadToEnd().ToString();
            sr.Close();
            return dd;
        }
    }
}
