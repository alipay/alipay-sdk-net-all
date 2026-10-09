using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalTradeDirectCloseResponse.
    /// </summary>
    public class AlipayCommerceMedicalTradeDirectCloseResponse : AopResponse
    {
        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 自费撤销描述
        /// </summary>
        [XmlElement("own_pay_cancel_msg")]
        public string OwnPayCancelMsg { get; set; }

        /// <summary>
        /// 自费撤销状态
        /// </summary>
        [XmlElement("own_pay_cancel_result")]
        public string OwnPayCancelResult { get; set; }

        /// <summary>
        /// 逸康交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
