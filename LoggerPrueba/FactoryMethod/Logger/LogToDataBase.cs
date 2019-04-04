using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerPrueba.FactoryMethod.TypeMessage;

namespace LoggerPrueba.FactoryMethod.Logger
{
    public class LogToDataBase : Logger
    {
        string _message;
        string _date;
        MessageType _messageType;
        string _ConnectionString;

        public LogToDataBase(Message message)
        {
            ReadAllSettings();
            //estos campos se cargan desde el app.config
            
            _date = _dtNow;
            _ConnectionString = _cnn;

            _message = message.MessageProperty;
            _messageType = message.MessageTypeProperty;
            
        }

        public override void LogMessage()
        {
            CreateCommand("Insert into Log Values('" + _messageType + "', '" + _date + "', '" + _message + "')", _ConnectionString);
        }

        private static void CreateCommand(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
        
    }

    
}
