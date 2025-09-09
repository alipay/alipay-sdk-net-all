using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryPerformRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryPerformRefundQueryModel : AopObject
    {
        /// <summary>
        /// 业务受理平台业务28位订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务受理平台退款请求号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
