using System;
using System.Collections.Generic;
using System.Text;

namespace CSharCodes
{
    public class StopWatch
    {
        public static TimeSpan Start { get; set; }
        public static TimeSpan Stop { get; set; }
        public static TimeSpan Duration { get; set; }

        public static List<TimeSpan> records = new List<TimeSpan>();

        private static bool _started = false;
        private static bool _stopped = true;

        public StopWatch() { }

        public static void StartRecord()
        {
            if (_started)
            {
                throw new InvalidOperationException("cannot start already started stopwatch!");
            }
            Start = DateTime.Now.TimeOfDay;
            _started = true;
            _stopped = false;
        }

        public static string StopRecord()
        {
            if (_stopped)
                throw new InvalidOperationException("cannot stop already stopped stopwatch!");
            Stop = DateTime.Now.TimeOfDay;
            Duration = Stop - Start;
            records.Add(Duration);
            _started = false;
            _stopped = true;
            return Duration.ToString();
        }

        public static string PrintRecords()
        {
            //var sb = new StringBuilder("\nRecords:\n");
            //var i = 1;
            //foreach (var record in records)
            //{
            //    sb.AppendLine($"{i}. {record}");
            //    i++;
            //} 
            //return sb.ToString();

            //Chatgpt response oto make this better
            var recordStrings = new List<string>();
            for (int i = 0; i < records.Count; i++)
            {
                recordStrings.Add($"{i + 1}. {records[i]}");
            }
            return "\nRecords:\n" + string.Join(Environment.NewLine, recordStrings);

        }

        public static void TimePass(int time)
        {
            var sb = new StringBuilder(".");
            var i = 0;
            while (true)
            {
                if (i % 3 == 0)
                {
                    sb.Clear();
                }
                sb.Append(".");
                Console.Write($"\r{sb.ToString()}   ");
                i++;
                if (i == time) break;
            }
        }

    }
}
        //public void implementation()
        //{
        //    StopWatch.StartRecord();

        //    StopWatch.TimePass(100000);

        //    Console.WriteLine(StopWatch.StopRecord().ToString());

        //    //var sb = new StringBuilder(".");
        //    StopWatch.StartRecord();

        //    StopWatch.TimePass(100000);

        //    Console.WriteLine(StopWatch.StopRecord());


        //    StopWatch.StartRecord();

        //    StopWatch.TimePass(100000);

        //    Console.WriteLine(StopWatch.StopRecord());

        //    StopWatch.StartRecord();

        //    StopWatch.TimePass(100000);

        //    Console.WriteLine(StopWatch.StopRecord());

        //    //Console.WriteLine(StopWatch.StopRecord());

        //    //StopWatch.StartRecord();
        //    //StopWatch.StartRecord();

        //    Console.WriteLine(StopWatch.PrintRecords());
        //}