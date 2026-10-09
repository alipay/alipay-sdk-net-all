using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionOrderQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }
    }
}
