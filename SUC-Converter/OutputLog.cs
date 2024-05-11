using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SUC_Converter
{
    public class OutputLog
    {
        private static string m_Output;
        public static string Output
        {
            get
            {
                return m_Output;
            }
            set
            {
                m_Output = value;
                UpdateOutput();
            }
        }

        public static event EventHandler OutputChanged = delegate { };

        protected static void OnOutputChanged(EventArgs e)
        {
            EventHandler handler = OutputChanged;           
            handler(null, e);            
        }

        public static void UpdateOutput()
        {
            OnOutputChanged(EventArgs.Empty);
        }

        public enum Severity
        {
            Info,
            Warning,
            Error
        }
        public static void Log(string message, Severity severity = Severity.Info)
        {

            string prefix = "[INFO] ";
            switch(severity)
            {
                case Severity.Warning:
                    {
                        prefix = "[WARN] ";
                        break;
                    }
                    case Severity.Error:
                    {
                        prefix = "[ERROR] ";
                        break;
                    }
            }
            Output += prefix + message + "\n";
        }
    }
}
