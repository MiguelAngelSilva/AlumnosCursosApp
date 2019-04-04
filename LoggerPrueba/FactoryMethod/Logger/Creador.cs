using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerPrueba;
using LoggerPrueba.FactoryMethod.TypeMessage;


namespace LoggerPrueba.FactoryMethod.Logger
{
    public class Creador
    {
        public static Logger CreadorLogger(LoggerType loggerType, Message message) {
            switch (loggerType)
            {
                case LoggerType.ToFile:
                    return new LogToFile(message);
                    
                case LoggerType.ToDataBase:
                    return new LogToDataBase(message);
                   
                case LoggerType.ToConsole:
                    return new LogToConsole(message);
                    
                default:
                    return null;
            }
        } 
    }
    

}
