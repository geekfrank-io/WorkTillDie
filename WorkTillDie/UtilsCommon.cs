using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;

namespace WorkTillDie
{
    public class UtilsCommon
    {
        //定义一个私有的静态全局变量来保存该类的唯一实例
        private static UtilsCommon instance;

        //线程锁
        private static readonly object _Object = new object();

        /// <summary>
        /// 构造函数
        /// </summary>
        private UtilsCommon()
        {
            //必须是私有的构造函数，这样就可以保证该类无法通过new来创建该类的实例。
            //想要使用该类只能通过唯一访问点GetInstance()。
        }
        /// <summary>
        /// 全局访问点
        /// 设置为静态方法则可在外边无需创建该类的实例就可调用该方法
        /// </summary>
        /// <returns></returns>
        internal static UtilsCommon GetInstance()
        {
            if (instance == null)//第一重
            {
                lock (_Object)
                {
                    if (instance == null)//第二重
                    {
                        instance = new UtilsCommon();
                    }
                }
            }
            return instance;
        }

        public string GetRecordFile()
        {
            string appDataPath = System.Reflection.Assembly.GetEntryAssembly().Location;// Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filename = Path.Combine(Path.GetDirectoryName(appDataPath), "WorkTillDie", "PCRunningRecords.xml");
            if (!File.Exists(filename))
            {
                CreatePCRunningRecords(filename);
            }
            return filename;
        }

        private void CreatePCRunningRecords(string filename)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filename)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filename));
            }
            XmlDocument xmlDoc = new XmlDocument();
            // 创建Xml declaration
            XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            xmlDoc.AppendChild(xmlDeclaration);

            // 创建根元素
            XmlElement rootElement = xmlDoc.CreateElement("Records");
            xmlDoc.AppendChild(rootElement);
            xmlDoc.Save(filename);

        }

        public bool AddRecord(DateTime time)
        {
            //DateTime timeUTC = DateTime.UtcNow;
            //DateTime timeNow = DateTime.Now;
            string filename = GetRecordFile();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            long utc = time.ToFileTimeUtc();
            int year = time.Year;
            int month = time.Month;
            int day = time.Day;
            int hour = time.Hour;//属性返回的是24小时制的小时数
            int minute = time.Minute;
            int second = time.Second;
            int milliSecond = time.Millisecond;
            XmlElement root = (XmlElement)xmlDoc.SelectSingleNode("Records");
            if (root == null) return false;
            XmlElement xmlYear = (XmlElement)root.SelectSingleNode($"Year[@Value='{year}']");
            if (xmlYear == null)
            {
                xmlYear = xmlDoc.CreateElement("Year");
                xmlYear.SetAttribute("Value", year.ToString());
                root.AppendChild(xmlYear);
            }
            XmlElement xmlMonth = (XmlElement)xmlYear.SelectSingleNode($"Month[@Value='{month}']");
            if (xmlMonth == null)
            {
                xmlMonth = xmlDoc.CreateElement("Month");
                xmlMonth.SetAttribute("Value", month.ToString());
                xmlYear.AppendChild(xmlMonth);
            }

            XmlElement xmlDay = (XmlElement)xmlMonth.SelectSingleNode($"Day[@Value='{day}']");
            if (xmlDay == null)
            {
                xmlDay = xmlDoc.CreateElement("Day");
                xmlDay.SetAttribute("Value", day.ToString());
                xmlMonth.AppendChild(xmlDay);
            }
            XmlElement xmlRecord = xmlDoc.CreateElement("Record");
            xmlRecord.SetAttribute("Value", time.ToUniversalTime().Ticks.ToString());
            xmlRecord.InnerText = time.ToString("yyyy-MM-dd HH:mm:ss:ffff");//

            xmlDay.AppendChild(xmlRecord);
            xmlDoc.Save(filename);

            return true;
        }

        public DateTime[] getAllRecordsOfTheDay(DateTime time)
        {
            List<DateTime> listDatetime = new List<DateTime>();
            string filename = GetRecordFile();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            long utc = time.ToFileTimeUtc();
            int year = time.Year;
            int month = time.Month;
            int day = time.Day;
            int hour = time.Hour;//属性返回的是24小时制的小时数
            int minute = time.Minute;
            int second = time.Second;
            int milliSecond = time.Millisecond;
            XmlElement root = (XmlElement)xmlDoc.SelectSingleNode("Records");
            if (root == null) return null;
            XmlElement xmlYear = (XmlElement)root.SelectSingleNode($"Year[@Value='{year}']");
            if (xmlYear == null) return null;
            XmlElement xmlMonth = (XmlElement)xmlYear.SelectSingleNode($"Month[@Value='{month}']");
            if (xmlMonth == null) return null;

            XmlElement xmlDay = (XmlElement)xmlMonth.SelectSingleNode($"Day[@Value='{day}']");
            if (xmlDay == null || xmlDay.ChildNodes.Count == 0) return null;

            foreach (XmlElement xmlRecord in xmlDay.ChildNodes)
            {
                string str = xmlRecord.InnerText;// = time.ToString("yyyy-MM-dd HH:mm:ss:ffff");
                //DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                //dtFormat.ShortDatePattern = "yyyy-MM-dd HH:mm:ss:ffff";
                DateTime t = DateTime.ParseExact(str, "yyyy-MM-dd HH:mm:ss:ffff", null);
                listDatetime.Add(t);
            }
            return listDatetime.ToArray();
        }

        public DateTime[] getAllRecordsOfEveryday()
        {
            List<DateTime> listDatetime = new List<DateTime>();
            string filename = GetRecordFile();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            XmlElement root = (XmlElement)xmlDoc.SelectSingleNode("Records");
            if (root == null) return null;
            XmlNodeList nodeList = root.SelectNodes("Year/Month/Day/Record");
            foreach (XmlNode node in nodeList)
            {
                string str = node.InnerText;
                //DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                //dtFormat.ShortDatePattern = "yyyy-MM-dd HH:mm:ss:ffff";
                DateTime t = DateTime.ParseExact(str, "yyyy-MM-dd HH:mm:ss:ffff", null);
                listDatetime.Add(t);
            }
            return listDatetime.ToArray();
        }

        public List<List<DateTime>> getAllRecordsByGroup()
        {
            List<List<DateTime>> listDatetimeGroup = new List<List<DateTime>>();
            string filename = GetRecordFile();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            XmlElement root = (XmlElement)xmlDoc.SelectSingleNode("Records");
            if (root == null) return null;
            XmlNodeList nodeDayList = root.SelectNodes("Year/Month/Day");
            foreach (XmlNode nodeDay in nodeDayList)
            {
                List<DateTime> listDatetime = new List<DateTime>();
                foreach (XmlNode node in nodeDay)
                {
                    string str = node.InnerText;
                    //DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                    //dtFormat.ShortDatePattern = "yyyy-MM-dd HH:mm:ss:ffff";
                    DateTime t = DateTime.ParseExact(str, "yyyy-MM-dd HH:mm:ss:ffff", null);
                    listDatetime.Add(t);
                }
                listDatetimeGroup.Add(listDatetime);
            }
            return listDatetimeGroup;
        }



    }

    public class TimeLog
    {
        public DateTime Time;
        public string Value { get; private set; }
        public string Note { get; set; }

        public TimeLog(DateTime dateTime, string Note = null)
        {
            Time = dateTime;
            Value = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            if (Note != null)
            {
                this.Note = Note;
            }
        }
    }

    public class WorkingTime
    {
        // 日期
        public string Date { get; }
        // 星期
        public DayOfWeek DayOfWeek { get; }
        // 时间记录
        public List<TimeLog> TimeLogs { get; }
        private DateTime StartTime;
        private DateTime EndTime;
        // 最早时间记录
        public string StartValue { get; }
        //最新时间记录
        public string EndValue { get; }
        private TimeSpan TimeSpan;
        //上班时间
        public string WorkingSpan { get; }
        // 加班时长（以分钟显示）
        public double ExtraMinutes { get; }
        // 加班时长（以小时显示）
        public string ExtraTime { get; }
        public WorkingTime(List<DateTime> listTime)
        {
            listTime.Sort();

            TimeLogs = new List<TimeLog>();
            foreach (DateTime t in listTime)
            {
                TimeLog log = new TimeLog(t);
                TimeLogs.Add(log);
            }

            TimeLog startLog = TimeLogs.FirstOrDefault();
            StartTime = startLog.Time;
            startLog.Note = "StartTime";

            DayOfWeek = StartTime.DayOfWeek;
            Date = StartTime.ToString("yyyy-MM-dd");
            StartValue = StartTime.ToString("HH:mm:ss");

            if (TimeLogs.Count > 1)
            {
                TimeLog endLog = TimeLogs.LastOrDefault();
                endLog.Note = "EndTime";
                EndTime = endLog.Time;
                EndValue = EndTime.ToString("HH:mm:ss");
                TimeSpan = EndTime.Subtract(StartTime);
                WorkingSpan = TimeSpan.ToString("g");
                if(TimeSpan.TotalMinutes>540)
                {
                    TimeSpan time = new TimeSpan(9, 0, 0);
                    ExtraMinutes = Math.Floor(TimeSpan.TotalMinutes)-540;
                    ExtraTime = TimeSpan.Subtract(time).ToString();
                }
            }



        }
    }


}
