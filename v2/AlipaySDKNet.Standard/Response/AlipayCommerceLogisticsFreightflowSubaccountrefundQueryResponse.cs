using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountrefundQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsFreightflowSubaccountrefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 实际退款成功金额，单位分，仅当退款成功时消费。
        /// </summary>
        [XmlElement("real_refund_amt")]
        public string RealRefundAmt { get; set; }

        /// <summary>
        /// 实际退款币种，人民币默认156或者CNY，仅当退款成功时消费。
        /// </summary>
        [XmlElement("real_refund_amt_currency_value")]
        public string RealRefundAmtCurrencyValue { get; set; }

        /// <summary>
        /// 退款处理进度   ○ 退款成功SUCCESS   ○ 退款失败FAIL，本次应该不会出现   ○ 退款处理中PROCESSING   ○ 挂账CHARGE_UP，挂账代表退回到对方银行失败，网商内部挂账，请引导用户联系网商
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }
    }
}
