using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiseTest
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "Получение списка ID отчетов по периоду")]
        public GetReportIdArrayResult GetReportIdArray(GetReportIdArrayArg arg)
        {
            return new GetReportIdArrayResult()
            {
                ReportIdArray = new int[] { 357, 358, 360, 361 }
            };
        }

        [WebMethod(Description = "Получение отчета по ID")]
        public GetReportResult GetReport(GetReportArg arg)
        {
            return new GetReportResult()
            {
                Report = new FinReport
                {
                    ReportID = arg.ReportID,
                    Date = new DateTime(2015, 03, 15),
                    Info = getReportInfo(arg.ReportID)
                }
            };
        }

        private string getReportInfo(int reportID)
        {
            return "ReportID = " + reportID;
        }
    }


    //    [Serializable]
    //    [XmlType(Namespace = FinReportService.XmlNS)]
    public class FinReport
    {
        public int ReportID { get; set; }
        public DateTime Date { get; set; }
        public string Info { get; set; }
    }

    public class GetReportIdArrayArg
    {
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
    }

    public class GetReportIdArrayResult
    {
        public int[] ReportIdArray { get; set; }
    }

    public class GetReportArg
    {
        public int ReportID { get; set; }
    }

    public class GetReportResult
    {
        public FinReport Report { get; set; }
    }
}
}
