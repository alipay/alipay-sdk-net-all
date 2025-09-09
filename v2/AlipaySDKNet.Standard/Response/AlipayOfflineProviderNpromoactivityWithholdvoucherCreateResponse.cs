using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpromoactivityWithholdvoucherCreateResponse.
    /// </summary>
    public class AlipayOfflineProviderNpromoactivityWithholdvoucherCreateResponse : AopResponse
    {
        /// <summary>
        /// 代扣协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 信用单号
        /// </summary>
        [XmlElement("credit_order_no")]
        public string CreditOrderNo { get; set; }

        /// <summary>
        /// 可代扣金额，单位元
        /// </summary>
        [XmlElement("debiting_amount")]
        public string DebitingAmount { get; set; }

        /// <summary>
        /// 代扣单号，获取后调用代扣接口发起代扣。
        /// </summary>
        [XmlElement("debiting_order_no")]
        public string DebitingOrderNo { get; set; }

        /// <summary>
        /// 代扣交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
