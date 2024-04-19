using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOrderPrepayResponse.
    /// </summary>
    public class AlipayTradeOrderPrepayResponse : AopResponse
    {
        /// <summary>
        /// 支付跳转信息。 用于打开支付方式 app 的 scheme URL，详细使用方式参考<a href="https://global.alipay.com/docs/ac/cashier_payment_cn/redirection#FH33G">链接</a>。
        /// </summary>
        [XmlElement("jump_info")]
        public JumpInfo JumpInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 账户机构唤端需要的订单唯一标识
        /// </summary>
        [XmlElement("tn")]
        public string Tn { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
