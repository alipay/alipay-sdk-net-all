using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollectReceiptOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CollectReceiptOpenApiDTO : AopObject
    {
        /// <summary>
        /// 外部业务单据号
        /// </summary>
        [XmlElement("bsn_no")]
        public string BsnNo { get; set; }

        /// <summary>
        /// 最初收款单的bsnRefNo，收款单拆分时使用，用于核对，找到最原始收款单
        /// </summary>
        [XmlElement("bsn_ref_no")]
        public string BsnRefNo { get; set; }

        /// <summary>
        /// 收款单对应的业务场景
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 渠道， 01：支付宝 02：银行渠道 12:  信用证
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付渠道的流水单号(银行、支付宝的付款流水单号)
        /// </summary>
        [XmlElement("channel_log_no")]
        public string ChannelLogNo { get; set; }

        /// <summary>
        /// 支付渠道的原始备注（银行、支付宝的流水备注）
        /// </summary>
        [XmlElement("channel_memo")]
        public string ChannelMemo { get; set; }

        /// <summary>
        /// 收款单金额
        /// </summary>
        [XmlElement("collect_amt")]
        public MultiCurrencyMoneyOpenApi CollectAmt { get; set; }

        /// <summary>
        /// 交易时间（收款流水的交易时间）
        /// </summary>
        [XmlElement("collect_date")]
        public string CollectDate { get; set; }

        /// <summary>
        /// 收款单的收款状态  * 未收款: UNCOLLECTED  * 已收款: COLLECTED
        /// </summary>
        [XmlElement("collect_status")]
        public string CollectStatus { get; set; }

        /// <summary>
        /// 已实收金额
        /// </summary>
        [XmlElement("collected_amt")]
        public MultiCurrencyMoneyOpenApi CollectedAmt { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 收款单冻结金额
        /// </summary>
        [XmlElement("freeze_amt")]
        public MultiCurrencyMoneyOpenApi FreezeAmt { get; set; }

        /// <summary>
        /// 流水平台的流水号
        /// </summary>
        [XmlElement("fund_log_id")]
        public string FundLogId { get; set; }

        /// <summary>
        /// 打款币种对实收币种的GL里的汇率
        /// </summary>
        [XmlElement("gl_exchange_rate")]
        public string GlExchangeRate { get; set; }

        /// <summary>
        /// 生成时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 收款方账号名称
        /// </summary>
        [XmlElement("payee_account_name")]
        public string PayeeAccountName { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("payee_account_no")]
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 收款方机构id
        /// </summary>
        [XmlElement("payee_inst_id")]
        public string PayeeInstId { get; set; }

        /// <summary>
        /// 收款方PID
        /// </summary>
        [XmlElement("payee_ip_role_id")]
        public string PayeeIpRoleId { get; set; }

        /// <summary>
        /// 付款方账号名称
        /// </summary>
        [XmlElement("payer_account_name")]
        public string PayerAccountName { get; set; }

        /// <summary>
        /// 付款方账号
        /// </summary>
        [XmlElement("payer_account_no")]
        public string PayerAccountNo { get; set; }

        /// <summary>
        /// 付款方支行名称
        /// </summary>
        [XmlElement("payer_bank_branch_name")]
        public string PayerBankBranchName { get; set; }

        /// <summary>
        /// 付款方机构id
        /// </summary>
        [XmlElement("payer_inst_id")]
        public string PayerInstId { get; set; }

        /// <summary>
        /// 付款方PID
        /// </summary>
        [XmlElement("payer_ip_role_id")]
        public string PayerIpRoleId { get; set; }

        /// <summary>
        /// 收款单号(主键字段)
        /// </summary>
        [XmlElement("receipt_no")]
        public string ReceiptNo { get; set; }

        /// <summary>
        /// 关联的资金交易唯一单号，用于与流水关联
        /// </summary>
        [XmlElement("ref_trans_no")]
        public string RefTransNo { get; set; }

        /// <summary>
        /// 关联的资金交易唯一单号的类型，用于与流水关联，可空. GFFUND_GTIT_NO:财资平台的调拨号 ALIPAY_TRANS_NO:支付宝交易号 RECEIVE_APPLY_NO:收款引擎受理单号
        /// </summary>
        [XmlElement("ref_trans_no_type")]
        public string RefTransNoType { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 收款单状态 * 待充值预收户: WAITING_RECHARGE * 未使用: NO_USE * 部分使用: PART_USE * 全部使用: ALL_USE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 收款单已使用金额
        /// </summary>
        [XmlElement("used_amt")]
        public MultiCurrencyMoneyOpenApi UsedAmt { get; set; }

        /// <summary>
        /// 自动核销关联号
        /// </summary>
        [XmlElement("writeoff_relative_id")]
        public string WriteoffRelativeId { get; set; }
    }
}
