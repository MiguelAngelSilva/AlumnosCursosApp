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
        string _date;
        string _ConnectionString;
        Message _message;

        public LogToDataBase(Message message)
        {
            ReadAllSettings();
            _message = message;
            //estos campos se cargan desde el app.config
            _date = _dtNow;
            _ConnectionString = _cnn;
        }

        public override void LogMessage()
        {
            CreateCommand("Insert into Log Values('" + _message.MessageTypeProperty + "', '" + _date + "', '" + _message.MessageProperty + "')", _ConnectionString);
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
