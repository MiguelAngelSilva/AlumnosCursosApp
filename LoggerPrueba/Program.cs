using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerPrueba.FactoryMethod.TypeMessage;

namespace LoggerPrueba
{
    class Program
    {
        static void Main(string[] args)
        {


            //ReadAllSettings();
            //ReadSetting("Error");
            //ReadSetting("");
            //TecsoLogger tl = new TecsoLogger(true, true, true, true, true, true);

            try
            {
                TecsoLogger.LogMessage(CreadorMensaje.CreadorMessageType(MessageType.Info, "Info message"));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
            Console.ReadKey();

        }

        private static void ReadAllSettings() {
            //AppSettingsReader ar = new AppSettingsReader();
            //bool logInfo = (bool)ar.GetValue("Info", typeof(bool));
            //bool logWarning = (bool)ar.GetValue("Warning", typeof(bool));
            //bool logError = (bool)ar.GetValue("Error", typeof(bool));
            //bool logToFile = (bool)ar.GetValue("LogToFile", typeof(bool));
            //bool logToConsole = (bool)ar.GetValue("LogToConsole", typeof(bool));
            //bool logToDatabase = (bool)ar.GetValue("LogToDatabase", typeof(bool));
            //Console.WriteLine($"LogInfo: {logInfo}\n");
            //Console.WriteLine($"logWarning: {logWarning}\n");
            //Console.WriteLine($"LogError: {logError}\n");
            //Console.WriteLine($"LogToFile: {logToFile}\n");
            //Console.WriteLine($"LogToConsole: {logToConsole}\n");
            //Console.WriteLine($"LogToDatabase: {logToDatabase}\n");

            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
        static void ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                Console.WriteLine(result);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

    }
}
