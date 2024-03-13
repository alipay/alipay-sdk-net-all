using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphoneOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 信用购主单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 已支付
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
