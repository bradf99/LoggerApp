using System;
using System.IO;


namespace LoggerApp
{
    public class Log
    {
        private StreamWriter sw;
        private string path = Directory.GetCurrentDirectory();
        private string filename;

        public string FileName
        {
            get
            {
                return path + @"\" + filename;
            }
        }

        #region Constructor
        public Log()
        {
            path += @"\Log";

            #region AssignLogFileName
            //sets the log file name properly according to the number of minutes elapsed.
            if (DateTime.Now.Minute < 10)
            {
                filename = String.Concat(DateTime.Now.Year.ToString() + "_",
                                                   DateTime.Now.Month.ToString() + "_",
                                                   DateTime.Now.Day.ToString() + "_",
                                                   DateTime.Now.Hour,
                                                   "0" + DateTime.Now.Minute,
                                                   ".txt");
            }
            else
            {
                filename = String.Concat(DateTime.Now.Year.ToString() + "_",
                                                   DateTime.Now.Month.ToString() + "_",
                                                   DateTime.Now.Day.ToString() + "_",
                                                   DateTime.Now.Hour,
                                                   DateTime.Now.Minute,
                                                   ".txt");
            }
            #endregion

            string logfilename = path + @"\" + filename;
            //check to see if the Log directory exists if not create it.
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);

            }
            //if logfile does not exist create and open it, otherwise open for append.
            if (!File.Exists(logfilename))
            {
                File.Create(logfilename).Close();
                sw = new StreamWriter(logfilename);
            }
            else
            {
                sw = new StreamWriter(logfilename, true);
            }

            sw.WriteLine("Logging started at : ".PadRight(75) + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

        }
        #endregion

        #region Methods
        public void Write(string message)
        {
            sw.WriteLine(message.PadRight(75)  + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
        }

        public void Close()
        {
            sw.WriteLine("Logging stopped at : ".PadRight(75) + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            sw.Close();
        }
        #endregion

    }
}
