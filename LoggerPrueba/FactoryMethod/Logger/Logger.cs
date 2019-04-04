using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerPrueba.FactoryMethod.Logger
{
    public abstract class Logger
    {
        internal static bool _logToFile;
        internal static bool _logToConsole;
        internal static bool _logToDatabase;
        internal static bool _logInfo;
        internal static bool _logWarning;
        internal static bool _logError;
        internal static string _filePathLog;
        internal static string _fileNamePrefix;
        internal static string _fileExtension;
        internal static string _filePathComplete;
        internal static string _dtNow = DateTime.Now.ToString("yyyyMMdd");
        internal static string _cnn;
        public abstract void LogMessage();

        internal static void ReadAllSettings()
        {
            try
            {
                AppSettingsReader ar = new AppSettingsReader();
                _logInfo = (bool)ar.GetValue("Info", typeof(bool));
                _logWarning = (bool)ar.GetValue("Warning", typeof(bool));
                _logError = (bool)ar.GetValue("Error", typeof(bool));
                _logToFile = (bool)ar.GetValue("LogToFile", typeof(bool));
                _logToConsole = (bool)ar.GetValue("LogToConsole", typeof(bool));
                _logToDatabase = (bool)ar.GetValue("LogToDatabase", typeof(bool));
                //Ejemplo sobre como se conforma el nombre de archivo
                //<add key="FilePathLog" value="C:\TecsoLogger\"/>
                //<add key="FileNamePrefix" value="File_Log_"/>
                //<add key="FileExtension" value=".txt"/>
                //al final se concatena todo en _filePathComplete
                _filePathLog = (string)ar.GetValue("FilePathLog", typeof(string));
                _fileNamePrefix = (string)ar.GetValue("FileNamePrefix", typeof(string));
                _fileExtension = (string)ar.GetValue("FileExtension", typeof(string));
                _filePathComplete = _filePathLog + _fileNamePrefix + _dtNow + _fileExtension;
                _cnn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            }
            catch (InvalidCastException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception(ex.Message);
                //throw new Exception("The key does not exist in the configuration section of application settings.");
            }
            catch (ConfigurationErrorsException)
            {
                throw new Exception("Error reading app settings");
            }
        }
    }
}
