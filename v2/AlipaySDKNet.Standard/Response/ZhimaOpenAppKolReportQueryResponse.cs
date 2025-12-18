using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaOpenAppKolReportQueryResponse.
    /// </summary>
    public class ZhimaOpenAppKolReportQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_list")]
        [XmlArrayItem("rent_kol_daily_report_v_o")]
        public List<RentKolDailyReportVO> ReportList { get; set; }
    }
}
