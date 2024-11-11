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
    }
}
