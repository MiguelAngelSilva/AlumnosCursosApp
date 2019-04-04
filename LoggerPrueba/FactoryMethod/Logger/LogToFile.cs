using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerPrueba.FactoryMethod.TypeMessage;

namespace LoggerPrueba.FactoryMethod.Logger
{
    public class LogToFile : Logger
    {
        string _lines = string.Empty;

        public LogToFile(Message message)
        {
            ReadAllSettings();
            //estos campos se cargan desde el app.config
            _filePath = _filePathComplete;
            _date = _dtNow;

            _message = message.MessageProperty;
            _messageType = message.MessageTypeProperty;

        }
        public override void LogMessage()
        {
            ReadFile();
            WriteFile();
        }

        string _filePath;
        string _message;
        string _date;
        MessageType _messageType;

        private void ReadFile()
        {
            if (System.IO.File.Exists(_filePath))
            {
                _lines = System.IO.File.ReadAllText(_filePath);
            }
        }
        private void WriteFile()
        {
            _lines = _lines + Environment.NewLine + _messageType + " - " +  _date + " - " + _message;
            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine(_lines);
            }
        }
    }
   
}
