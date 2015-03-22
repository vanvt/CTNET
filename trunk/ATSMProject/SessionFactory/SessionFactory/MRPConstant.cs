using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace JVL
{
    public enum CMSDOCUMENTTYPE
    {
        ORD001 = 1,//Phiếu nhận in
        REQ001 = 2 //Phiếu thiết kế vi tính
    }

    public static class MRPConstant
    {
        public static string errorMessage = "";
        public static String ORDERTYPE ="ORDERTYPE";
        public static int PNI = 1;
        public static int HD = 2;

        public static int BUY = 1;
        public static int SALE = 2;

        public static int PRODUCTIONREQUIREMENT = 1;//Lenh san xuat
        public static int TEMPLATEFILE= 2;//Thiet ke
        public static int TEMPLATEFILM = 3; //Bình bản
        public static int TEMPLATEZINC = 4; //Phơi bản
        public static int TEMPLATEFILMCTP = 9; // Phiếu bình bản CTP
        public static int TEMPLATEZINCCTP = 5; //Ghi kẽm CTP
        public static int MATERIALREQUIREMENT = 6; //Yêu cầu vật tư
        public static int NUMBERROWPERPAGE = 20;
        public enum PRODUCTYPE
        {
            MATERIAL = 1,
            PRODUCT = 2
        }

        public enum MATERIALTYPE
        {
            PAPER = 1,
            INK = 2,
            ZINC = 3,
        }
        public enum REQUIRENTMENTTYPE
        {
            PRODUCTIONREQUIREMENT = 1,//Lenh san xuat
            TEMPLATEFILE = 2,//Thiet ke
            TEMPLATEFILM = 3, //Bình bản
            TEMPLATEZINC = 4, //Phơi bản
            TEMPLATEFILMCTP = 9, // Phiếu bình bản CTP
            TEMPLATEZINCCTP = 5, //Ghi kẽm CTP
            MATERIALREQUIREMENT = 6 //Yêu cầu vật tư
        }

        public enum REQUIRENTSTATUS
        {
            NEW = 0,
            IMPLEMENT = 1,
            DONE = 2

        }

        public enum IMPORTTYPE
        {
            KIEMDINH = 1,
            TAICHE = 2,
            MATERIAL = 3,
            PRODUCT = 4
        }

        public enum EXPORTTYPE
        {
            XUATSANXUAT = 1,
            XUATKIEMKE = 2
        }
        public enum PAPERSOURCE
        {
            CT=1,
            GC = 2
        }
    }
   
    public class CommonFunction
    {
        public static int GetWeekNumber(DateTime date)
        {
            //Constants
            const int JAN = 1;
            const int DEC = 12;
            const int LASTDAYOFDEC = 31;
            const int FIRSTDAYOFJAN = 1;
            const int THURSDAY = 4;
            bool thursdayFlag = false;
            int dayOfYear = date.DayOfYear;
            int startWeekDayOfYear = (int)(new DateTime(date.Year, JAN, FIRSTDAYOFJAN)).DayOfWeek;
            int endWeekDayOfYear = (int)(new DateTime(date.Year, DEC, LASTDAYOFDEC)).DayOfWeek;
            if (startWeekDayOfYear == 0)
                startWeekDayOfYear = 7;
            if (endWeekDayOfYear == 0)
                endWeekDayOfYear = 7;
            int daysInFirstWeek = 8 - (startWeekDayOfYear);

            if (startWeekDayOfYear == THURSDAY || endWeekDayOfYear == THURSDAY)
                thursdayFlag = true;
            int fullWeeks = (int)Math.Ceiling((dayOfYear - (daysInFirstWeek)) / 7.0);
            int resultWeekNumber = fullWeeks;
            if (daysInFirstWeek >= THURSDAY)
                resultWeekNumber = resultWeekNumber + 1;
            if (resultWeekNumber > 52 && !thursdayFlag)
                resultWeekNumber = 1;
            if (resultWeekNumber == 0)
                resultWeekNumber = GetWeekNumber(new DateTime(date.Year - 1, DEC, LASTDAYOFDEC));
            return resultWeekNumber;
        }
        public static DateTime FirstDateOfWeek(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);

            int daysOffset = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;

            DateTime firstMonday = jan1.AddDays(daysOffset);

            int firstWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(jan1, CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);

            if (firstWeek <= 1)
            {
                weekOfYear -= 1;
            }

            return firstMonday.AddDays(weekOfYear * 7);
        }
        public static DateTime convertDate(string strDate)
        {
            DateTime date;
            string convertedDate = String.Empty;
            if (DateTime.TryParseExact(strDate, "dd/MM/yyyy", null, DateTimeStyles.None, out date))
            {
                convertedDate = date.ToString("MM/dd/yyyy");
            }
            date = DateTime.Parse(convertedDate);

            return date;
        }
    }
}
