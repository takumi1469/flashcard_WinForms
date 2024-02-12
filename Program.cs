namespace Takumi_Saito_Project
{
    internal static class Program //This class holds variables/properties and methods for automatic login
    {
        static private string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "flashcardconfig.txt");
        static private string defaultUser = string.Empty;
        static private string defaultPassword = string.Empty;
        static private int defaultUserIndex = -1;
        static public string DefaultInputPath { get; set; } = string.Empty; //This is public because this will be accessed by Form1
        static public int HorizontalOffset { get; } = 350; //Constant for displaying all the forms in the same coordinate on display 
        static public int VerticalOffset { get; } = 200;  //Constant for displaying all the forms in the same coordinate on display 

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AutomaticLoginRead();
            AutomaticLogin();
            if (defaultUserIndex == -1) //automatic login did not succeed
                Application.Run(new Form1());

            else //automatic login succeeded
                Application.Run(new Form3(WordCardSystem.Users[defaultUserIndex]));
        }

        static private void AutomaticLoginRead() //Method to read initial config file
        {
            if (File.Exists(configPath))
            {
                string config = File.ReadAllText(configPath);
                List<string> configItems = new List<string>();
                int start = 0;
                int end = 0;
                while (end < config.Length)
                {
                    while (end < config.Length && config[end] != ',') //This order, otherwise the config[end] could be out of range
                    {//Config file must be formatted as "username,password,filepath,"
                        end++;
                    }
                    configItems.Add(config[start..end]);
                    end++;
                    start = end;
                }
                if (configItems.Count() == 3) //At least the input file had good comma-separated format
                {
                    defaultUser = configItems[0];
                    defaultPassword = configItems[1];
                    DefaultInputPath = configItems[2];
                }
            }
        }

        static private void AutomaticLogin() //Method to populate user data based on config file
        {
            int autoLoginResult = 0;
            int userCheckResult = -1;

            //User has chosen to do automatic login, so config file was found and default variables have been populated
            if (defaultUser != string.Empty && defaultPassword != string.Empty && DefaultInputPath != string.Empty)
            {
                //read from the DefaultInputPath file as specified in config file
                int inputResult = WordCardSystem.JsonInput(DefaultInputPath);
                if (inputResult == 1)
                    autoLoginResult = 1; //input success
                else
                    autoLoginResult = -1; //input failed

                //verify that the defaultUser exists in the data in defaultInputPath file
                if (autoLoginResult > 0) //input was success, now look for the user in the input data
                {
                    userCheckResult = WordCardSystem.CheckExistingUser(defaultUser);
                    if (userCheckResult != -1) //user was found
                        autoLoginResult = 2;
                    else
                        autoLoginResult = -2; //user does not exist
                }

                //verify that the defaultPassword matches the actual password of the defaultUser
                if (autoLoginResult == 2) //user was found, now check if the password matches
                {
                    if (defaultPassword == WordCardSystem.Users[userCheckResult].Password) //password matched
                        autoLoginResult = 3;
                    else
                        autoLoginResult = -3; //password doesn't match
                }

                //show Form3 as the defaultUser, and hide this form
                if (autoLoginResult == 3)
                {
                    defaultUserIndex = userCheckResult;
                }
            }
        }
    }
}