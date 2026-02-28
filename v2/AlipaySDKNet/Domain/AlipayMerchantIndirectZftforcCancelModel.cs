using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectZftforcCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectZftforcCancelModel : AopObject
    {
        /// <summary>
        /// 直付通c2c申请单
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
