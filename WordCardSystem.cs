using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Takumi_Saito_Project
{
    //Class to hold user data and methods related to user data. All the data in the system are tied to users.
    public static class WordCardSystem 
    {
        static public List<User> Users = new List<User>();

        public static int CheckExistingUser(string userName)
        {
            int check = -1;
            int index = 0;
            foreach (User user in Users)
            {
                if (user.UserName == userName)
                    check = index;
                index++;
            }
            return check; //If there is no match, -1 will be returned. Otherwise the matching index.
        }

        public static string OpenFile() //Method to ask user for and receive input file
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.InitialDirectory = desktopPath; //set initial path to desktop
                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    return filePath;
                }
                else
                    return "Error";
            }
        }

        public static int JsonInput(string filePath) //Method to deserialize the json input file
        {
            if (filePath != "Error")
            {
                string jsonString = File.ReadAllText(filePath);
                if (jsonString[0..13] == "[{\"UserName\":")
                {
                    Users = JsonSerializer.Deserialize<List<User>>(jsonString)!;
                    return 1; //input success

                }
                else
                    return 2; //input fail
            }
            return 0; //nothing is chosen
        }
        public static void JsonOutput() //Method to save data as json file
        {
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.InitialDirectory = desktopPath; //set initial path to desktop
                saveFileDialog.Filter = "json files (*.json)|*.json";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;
                }
                else
                    filePath = "Error";
            }

            string jsonOutput = JsonSerializer.Serialize(Users);
            FileStream stream = File.Open(filePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(jsonOutput);
            writer.Close();
        }
    }
}
