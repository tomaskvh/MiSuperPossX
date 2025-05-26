using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinFormsApp1.Lib
{
    public class logs
    {
        internal string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/MiSuperPossX/Logs/";
         
        public logs(String logl, bool openlog, int typeOfLog)
        {
            List<string> tol = ["INFO", "WARNING", "ERROR", "APP EXIT"];
            String tolText = tol[typeOfLog];
            DateTime d = DateTime.Now;
            String logline = "[" + d.ToString("dd/MM/yyyy HH:mm:ss") + " " + tolText + "] " + logl;

            if (openlog)
            {
                openLogFile();
            }

            String fpath = directoryPath + "appLogs.log";           

            FileManager fp = new FileManager(fpath);

            String writeFile = fp.getFileText()  + logline;
            fp.writeFile(writeFile);
        }
        private void openLogFile()
        {
            String dt = "appLogs";
            String fp = directoryPath + dt + ".log";
            FileManager fm = new FileManager(fp);
            fm.createFile("");
        }
    }
}
