using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerPrueba.FactoryMethod.TypeMessage
{
    public class CreadorMensaje
    {
        public static Message CreadorMessageType(MessageType messageType, string message)
        {
            switch (messageType)
            {
                case MessageType.Info:
                    return new Info(message, messageType);

                case MessageType.Warning:
                    return new Warning(message, messageType);

                case MessageType.Error:
                    return new Error(message, messageType);

                default:
                    return null;
            }
        }
    }
}
