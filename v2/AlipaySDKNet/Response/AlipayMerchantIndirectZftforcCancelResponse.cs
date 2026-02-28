using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectZftforcCancelResponse.
    /// </summary>
    public class AlipayMerchantIndirectZftforcCancelResponse : AopResponse
    {
        /// <summary>
        /// 撤销状态
        /// </summary>
        [XmlElement("cancel")]
        public bool Cancel { get; set; }

        /// <summary>
        /// 直付通c2c申请单
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
