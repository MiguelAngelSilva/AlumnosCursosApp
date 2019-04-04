using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerPrueba.FactoryMethod.TypeMessage
{
    public abstract class Message
    {
        public MessageType MessageTypeProperty { get; set; }
        public string MessageProperty { get; set; }
    }
}
