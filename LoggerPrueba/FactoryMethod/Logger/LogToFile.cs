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
        Message _message;
        string _filePath;
        string _date;
        public LogToFile(Message message)
        {
            ReadAllSettings();
            _message = message;
            //estos campos se cargan desde el app.config
            _filePath = _filePathComplete;
            _date = _dtNow;
        }
        public override void LogMessage()
        {
            ReadFile();
            WriteFile();
        }
        private void ReadFile()
        {
            if (System.IO.File.Exists(_filePath))
            {
                _lines = System.IO.File.ReadAllText(_filePath);
            }
        }
        private void WriteFile()
        {
            _lines = _lines + Environment.NewLine + _message.MessageTypeProperty + " - " +  _date + " - " + _message.MessageProperty;
            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine(_lines);
            }
        }
    }
   
}
