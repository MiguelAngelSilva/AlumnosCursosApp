using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerPrueba.FactoryMethod.TypeMessage
{
    public class Warning:Message
    {
        public Warning(string message, MessageType messageType)
        {
            MessageTypeProperty = messageType;
            MessageProperty = message;
        }
    }
}
