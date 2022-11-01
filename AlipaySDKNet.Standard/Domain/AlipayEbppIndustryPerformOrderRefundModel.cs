using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryPerformOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryPerformOrderRefundModel : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }
    }
}
