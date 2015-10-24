using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace WebService
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(Uravnenie aaa)
        {
            int sm = aaa.a + aaa.b;
            return "Сумма чисел равна:" + sm;
        }
    }

    [Serializable]
    [XmlType(Namespace = "http://tempuri.org/")]
    public class Uravnenie
    {
        public int a { get; set; }
        public int b { get; set; }
    }
}
