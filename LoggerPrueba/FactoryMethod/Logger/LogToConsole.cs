using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerPrueba.FactoryMethod.TypeMessage;

namespace LoggerPrueba.FactoryMethod.Logger
{
     public class LogToConsole:Logger
    {
        string _message;
        string _date;
        MessageType _messageType;

        public LogToConsole(Message message) {
            ReadAllSettings();
            //este campos se cargan desde el app.config
            _date = _dtNow;

            _message = message.MessageProperty;
            _messageType = message.MessageTypeProperty;
        }
        public override void LogMessage()
        {
            Console.WriteLine($"*******************************************");
            Console.WriteLine(_messageType + " - " +_date + " - " + _message);
        }

        
    }
}
