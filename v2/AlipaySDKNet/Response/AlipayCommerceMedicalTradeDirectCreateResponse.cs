using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalTradeDirectCreateResponse.
    /// </summary>
    public class AlipayCommerceMedicalTradeDirectCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝交易hao
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 创单成功后返回的收银台链接
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }

        /// <summary>
        /// 请求入参中传入的
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 逸康交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
