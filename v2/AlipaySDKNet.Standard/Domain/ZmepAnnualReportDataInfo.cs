using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepAnnualReportDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepAnnualReportDataInfo : AopObject
    {
        /// <summary>
        /// 企业工商年报数据
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("zmep_annual_report_info")]
        public List<ZmepAnnualReportInfo> Hits { get; set; }

        /// <summary>
        /// 记录条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
