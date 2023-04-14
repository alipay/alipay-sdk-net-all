using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataSummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniDataSummaryQueryModel : AopObject
    {
        /// <summary>
        /// 请求数据的日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
