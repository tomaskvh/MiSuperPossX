using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WinFormsApp1.Modelo;

namespace WinFormsApp1.Lib
{
    public class loginUser
    {
        internal string pathBase = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/MiSuperPossX/Data/";
        internal string userPath;
        internal string tempPath;
        internal List<ModelUser> users;
        internal FileManager uFile;
        internal FileManager tFile;
        public int code;
        
        public loginUser(int code) 
        { 
            this.code = code;
            this.userPath = pathBase + "Usuarios/data.json";
            this.tempPath = pathBase + "Temp/logged.txt";
            this.uFile = new FileManager(userPath);
            this.tFile = new FileManager(tempPath);

            string sJsonUserData = uFile.getFileText();

            this.users = JsonSerializer.Deserialize<List<ModelUser>>(sJsonUserData);
            new logs("LoginUsers: Constructor OK", false, 0);
        }
        public bool userExists()
        {
            int i = users.Count();
            bool ret = true;
            if (this.code >= i) ret = false;

            return ret;
        }
        public bool autenticate(int pin, bool add) 
        {
            bool ret = true;
            int p = users[this.code].pin;
            if (pin != p || !users[this.code].active) ret = false;
            if (!add && ret) 
            {
                tFile.createFile(this.code.ToString() +"-");
            }
            return ret;
        }
        public ModelUser userData()
        {

            ModelUser user = users[this.code];

            return user;
        }
        public string[] getCurrentLoggedUsersCodes()
        {
            new logs("LogginUser: INIT GCLUC", false, 0);
            string ttxt = tFile.getFileText();
            string[] us = ttxt.Split("-");

            return us;
        }
        public void logout() 
        { 

        }
    }
}

