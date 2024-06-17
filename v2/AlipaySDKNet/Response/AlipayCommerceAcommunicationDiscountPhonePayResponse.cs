using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationDiscountPhonePayResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationDiscountPhonePayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝业务订单号
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }
    }
}
