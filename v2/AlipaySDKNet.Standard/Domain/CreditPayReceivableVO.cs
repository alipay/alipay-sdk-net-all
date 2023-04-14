using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPayReceivableVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayReceivableVO : AopObject
    {
        /// <summary>
        /// 应收结清时间
        /// </summary>
        [XmlElement("clear_date")]
        public string ClearDate { get; set; }

        /// <summary>
        /// 应收创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 应收到期日
        /// </summary>
        [XmlElement("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 应收生效时间
        /// </summary>
        [XmlElement("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 费余额
        /// </summary>
        [XmlElement("fee_balance_amt")]
        public CreditPayMoneyVO FeeBalanceAmt { get; set; }

        /// <summary>
        /// 待扣费金额
        /// </summary>
        [XmlElement("fee_dbt_amt")]
        public CreditPayMoneyVO FeeDbtAmt { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [XmlElement("freeze_amt")]
        public CreditPayMoneyVO FreezeAmt { get; set; }

        /// <summary>
        /// 收款账号描述
        /// </summary>
        [XmlElement("grant_account")]
        public string GrantAccount { get; set; }

        /// <summary>
        /// 应收失效时间
        /// </summary>
        [XmlElement("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 买家信息
        /// </summary>
        [XmlElement("payer")]
        public CreditPayUserVO Payer { get; set; }

        /// <summary>
        /// 关联外部订单号
        /// </summary>
        [XmlElement("platform_order_no")]
        public string PlatformOrderNo { get; set; }

        /// <summary>
        /// 已打款金额
        /// </summary>
        [XmlElement("rct_amt")]
        public CreditPayMoneyVO RctAmt { get; set; }

        /// <summary>
        /// 可打款余额
        /// </summary>
        [XmlElement("rcv_balance_amt")]
        public CreditPayMoneyVO RcvBalanceAmt { get; set; }

        /// <summary>
        /// 应收金额
        /// </summary>
        [XmlElement("receivable_amt")]
        public CreditPayMoneyVO ReceivableAmt { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amt")]
        public CreditPayMoneyVO RefundAmt { get; set; }

        /// <summary>
        /// WAIT_CONFIRM：待确认 RECEIVABLE：已生效且存在未收金额 DUE_RECEIVED：已全额到期自动收款 FACTORING_RECEIVED：已全额提前收款 UNVALID：失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易原始金额
        /// </summary>
        [XmlElement("trade_origin_amt")]
        public CreditPayMoneyVO TradeOriginAmt { get; set; }

        /// <summary>
        /// 转让金额
        /// </summary>
        [XmlElement("transfer_amt")]
        public CreditPayMoneyVO TransferAmt { get; set; }
    }
}
