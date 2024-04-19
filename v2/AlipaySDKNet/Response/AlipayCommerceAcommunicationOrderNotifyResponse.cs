using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationOrderNotifyResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationOrderNotifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 外部商家订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// SUCCESS结算成功 FAILED失败退款
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
