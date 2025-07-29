using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpReportQueryModel : AopObject
    {
        /// <summary>
        /// 企信生成的报告订单号，用于唯一查询
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 报告类型。可选PDF和H5，不传入默认PDF
        /// </summary>
        [XmlElement("report_type")]
        public string ReportType { get; set; }
    }
}
