using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasOrderDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasOrderDetailQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }
    }
}
