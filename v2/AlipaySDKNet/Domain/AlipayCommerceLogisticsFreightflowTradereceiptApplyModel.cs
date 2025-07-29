using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowTradereceiptApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowTradereceiptApplyModel : AopObject
    {
        /// <summary>
        /// 账户编号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 结算户:SETTLE_ACCOUNT 子户:SUB_ACCOUNT 收款外标:PAYEE_CARD_NO
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式。 本期： ANT_MYBANK(网商银行模式)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行应用id,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 外部订单请求流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 申请交易凭证类型 单笔交易凭证： STANDARD_TRADE_RECEIPT
        /// </summary>
        [XmlElement("receipt_type")]
        public string ReceiptType { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 授权代付:ENTRUST_AUTH_PAY 授权划转:ENTRUST_ALLOCATE 转账:TRANSFER 充值收款/退款/退汇:SETTLE_ACCOUNT_RECEIPT 收银支付:CASHIER_PAY
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
