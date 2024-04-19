using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeRecordMqDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TradeRecordMqDTO : AopObject
    {
        /// <summary>
        /// 付款账号，非uid
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 专属账号
        /// </summary>
        [XmlElement("account_no_ex")]
        public string AccountNoEx { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 业务参考号
        /// </summary>
        [XmlElement("biz_ref_no")]
        public string BizRefNo { get; set; }

        /// <summary>
        /// 业务摘要
        /// </summary>
        [XmlElement("biz_summary")]
        public string BizSummary { get; set; }

        /// <summary>
        /// 手续费金额
        /// </summary>
        [XmlElement("charges_amount")]
        public string ChargesAmount { get; set; }

        /// <summary>
        /// 手续费币种
        /// </summary>
        [XmlElement("charges_currency_type")]
        public string ChargesCurrencyType { get; set; }

        /// <summary>
        /// 收款金额
        /// </summary>
        [XmlElement("credit_amount")]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency_type")]
        public string CurrencyType { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        [XmlElement("debit_amount")]
        public string DebitAmount { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 长沙银行
        /// </summary>
        [XmlElement("other_side_account_name")]
        public string OtherSideAccountName { get; set; }

        /// <summary>
        /// 收方账号，非uid
        /// </summary>
        [XmlElement("other_side_account_no")]
        public string OtherSideAccountNo { get; set; }

        /// <summary>
        /// 对方账号币种
        /// </summary>
        [XmlElement("other_side_currency_type")]
        public string OtherSideCurrencyType { get; set; }

        /// <summary>
        /// 其他摘要
        /// </summary>
        [XmlElement("other_summary")]
        public string OtherSummary { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 支付币种
        /// </summary>
        [XmlElement("payment_currency_type")]
        public string PaymentCurrencyType { get; set; }

        /// <summary>
        /// 流程实例号
        /// </summary>
        [XmlElement("process_no")]
        public string ProcessNo { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("sync_date")]
        public long SyncDate { get; set; }

        /// <summary>
        /// 影子标,只有为true才会是影子流量，false或者空都是正式流量
        /// </summary>
        [XmlElement("test_mode")]
        public bool TestMode { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("trade_date")]
        public long TradeDate { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 唯一编码
        /// </summary>
        [XmlElement("unique_no")]
        public string UniqueNo { get; set; }
    }
}
