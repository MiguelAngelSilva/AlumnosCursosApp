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
        string _date;
        Message _message;
        public LogToConsole(Message message) {
            ReadAllSettings();
            _message = message;
            //este campos se cargan desde el app.config
            _date = _dtNow;
        }
        public override void LogMessage()
        {
            Console.WriteLine($"*******************************************");
            Console.WriteLine(_message.MessageTypeProperty + " - " + _date + " - " + _message.MessageProperty);
        }
    }
}
