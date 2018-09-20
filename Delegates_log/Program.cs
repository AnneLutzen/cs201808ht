using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_log
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;
            m.Start();
            m.Stop();
        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }
    }

    public delegate void LogDelegate(string s);

    class Maskine
    {

        public LogDelegate Log { get; set; }

        public void Start()
        {           
            Log(@"Start " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
        }

        public void Stop()
        {
            Log(@"Stop " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
        }


    }
}
