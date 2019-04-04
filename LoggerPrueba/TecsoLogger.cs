using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;
using System.Security;
using LoggerPrueba.FactoryMethod.Logger;
using LoggerPrueba.FactoryMethod.TypeMessage;
using System.Collections.Generic;

namespace LoggerPrueba
{
    public class TecsoLogger
    {
        private static bool _logToFile;
        private static bool _logToConsole;
        private static bool _logToDatabase;
        private static bool _logInfo;
        private static bool _logWarning;
        private static bool _logError;
        
        public static void LogMessage(Message message)
        {
            try
            {
               
                
                ReadAllSettings();
                if (!ValidarConfiguracion(message)) return;
                
                foreach (var item in GetLoggerTypeList())
                {
                    Logger logger = Creador.CreadorLogger(item, message);
                    logger.LogMessage();
                }

              
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        /// <summary>
        /// Si en el app.config esta configurado que se tiene que hacer log en archivo y base de datos devuelvo la lista de los tipos de logger
        /// </summary>
        /// <returns>Lista de los tipos de logger</returns>
        private static List<LoggerType> GetLoggerTypeList() {
            List<LoggerType> _lsTemp = new List<LoggerType>(); 
            if (_logToFile){ _lsTemp.Add(LoggerType.ToFile); }
            if (_logToDatabase) { _lsTemp.Add(LoggerType.ToDataBase); }
            if (_logToConsole) { _lsTemp.Add(LoggerType.ToConsole); }
            return _lsTemp;
        }
        private static bool ValidarConfiguracion(Message message) {
            
            if (message == null || message.MessageProperty.Length == 0)
            {
                throw new Exception("Message is empty.");
            }
            
            if (!_logToConsole && !_logToFile && !_logToDatabase)
            {
                throw new Exception("Especify Logger Type");
            }
            if ((!_logError && !_logInfo && !_logWarning))
            {
                throw new Exception("Especify Message Type");
            }
            

            switch (message.MessageTypeProperty)
            {
                case MessageType.Info:
                    if (!_logInfo) 
                    return false;
                    break;
                case MessageType.Warning:
                    if (!_logWarning) 
                    return false;
                    break;
                case MessageType.Error:
                    if (!_logError) 
                    return false;
                    break;
                default:
                    return false;
                  
            }
            return true;
        }
       
        private static void ReadAllSettings()
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
                
            }
            catch (InvalidCastException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("The key does not exist in the configuration section of application settings.");
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }
    }
    public enum MessageType
    {
        Info = 1,
        Warning = 2,
        Error = 3
    }
    public enum LoggerType
    {
        ToFile = 1,
        ToDataBase = 2,
        ToConsole = 3
    }
}
