using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerPrueba.FactoryMethod.TypeMessage
{
    public class Error:Message
    {
        public Error(string message, MessageType messageType)
        {
            MessageTypeProperty = messageType;
            MessageProperty = message;
        }
    }
}
