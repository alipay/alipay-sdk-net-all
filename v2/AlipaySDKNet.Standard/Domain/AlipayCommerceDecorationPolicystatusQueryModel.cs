using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDecorationPolicystatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDecorationPolicystatusQueryModel : AopObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 保险产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
