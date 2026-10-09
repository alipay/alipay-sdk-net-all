using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationPhoneOrderPayResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationPhoneOrderPayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝业务订单号，支付宝充值平台生成业务单号，用来查看业务成功与否
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝收单交易号，用于查看B站账单核对资金
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }
    }
}
