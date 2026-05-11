using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneOnlineadvanceresultNotifyResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphoneOnlineadvanceresultNotifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝在线提前结清测算单号
        /// </summary>
        [XmlElement("alipay_online_advance_pay_order_no")]
        public string AlipayOnlineAdvancePayOrderNo { get; set; }
    }
}
