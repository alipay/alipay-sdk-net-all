using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalTradeCancelResponse.
    /// </summary>
    public class AlipayCommerceMedicalTradeCancelResponse : AopResponse
    {
        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 银行编码
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行订单ID
        /// </summary>
        [XmlElement("bank_order_id")]
        public string BankOrderId { get; set; }

        /// <summary>
        /// 当orderType=INSURANCE_PAY时该字段会返回
        /// </summary>
        [XmlElement("medical_pay_cancel_msg")]
        public string MedicalPayCancelMsg { get; set; }

        /// <summary>
        /// 当orderType=INSURANCE_PAY时该字段会返回
        /// </summary>
        [XmlElement("medical_pay_cancel_result")]
        public string MedicalPayCancelResult { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 当orderType=OWN_PAY时该字段会返回
        /// </summary>
        [XmlElement("own_pay_cancel_msg")]
        public string OwnPayCancelMsg { get; set; }

        /// <summary>
        /// 当orderType=OWN_PAY时该字段会返回
        /// </summary>
        [XmlElement("own_pay_cancel_result")]
        public string OwnPayCancelResult { get; set; }

        /// <summary>
        /// 整笔交易撤销结果
        /// </summary>
        [XmlElement("trade_cancel_result")]
        public string TradeCancelResult { get; set; }

        /// <summary>
        /// 逸康交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
