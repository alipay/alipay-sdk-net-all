using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtTreasuryPaymentAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtTreasuryPaymentAcceptModel : AopObject
    {
        /// <summary>
        /// 主动/被动；ACTIVE/PASSIVE
        /// </summary>
        [XmlElement("active_or_passive")]
        public string ActiveOrPassive { get; set; }

        /// <summary>
        /// 收款行本地清算行号
        /// </summary>
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 收款行本地清算分支行号
        /// </summary>
        [XmlElement("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// 收款渠道为银行且为收款方为境外国家/地区，且传递的付款账号的情况下必填的必填
        /// </summary>
        [XmlElement("charge_bearer")]
        public string ChargeBearer { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 银行/支付宝；BANK/ALIPAY
        /// </summary>
        [XmlElement("creditor_account_inner_type")]
        public string CreditorAccountInnerType { get; set; }

        /// <summary>
        /// 收款方账户名
        /// </summary>
        [XmlElement("creditor_account_name")]
        public string CreditorAccountName { get; set; }

        /// <summary>
        /// 非空，付款方账号
        /// </summary>
        [XmlElement("creditor_account_no")]
        public string CreditorAccountNo { get; set; }

        /// <summary>
        /// 收款渠道为银行且收款方为境外国家/地区必填，收款方地址
        /// </summary>
        [XmlElement("creditor_address")]
        public string CreditorAddress { get; set; }

        /// <summary>
        /// 收款行swiftcode，境内可空，境外/跨境非空
        /// </summary>
        [XmlElement("creditor_bic")]
        public string CreditorBic { get; set; }

        /// <summary>
        /// 收款人邮箱
        /// </summary>
        [XmlElement("creditor_contact_email")]
        public string CreditorContactEmail { get; set; }

        /// <summary>
        /// 收款方联系人名称
        /// </summary>
        [XmlElement("creditor_contact_name")]
        public string CreditorContactName { get; set; }

        /// <summary>
        /// 收款渠道为银行且收款方为境外国家/地区必填，收款方电话
        /// </summary>
        [XmlElement("creditor_contact_phone_number")]
        public string CreditorContactPhoneNumber { get; set; }

        /// <summary>
        /// 有尽量传；收款渠道为银行收款方为境外国家/地区必填的必填，收款方两位国家代码
        /// </summary>
        [XmlElement("creditor_country")]
        public string CreditorCountry { get; set; }

        /// <summary>
        /// 收方币种，英文
        /// </summary>
        [XmlElement("creditor_currency")]
        public string CreditorCurrency { get; set; }

        /// <summary>
        /// 收款方财务机构ID，如：Z64、Z77
        /// </summary>
        [XmlElement("creditor_fin_inst_id")]
        public string CreditorFinInstId { get; set; }

        /// <summary>
        /// 可空，欧盟非空
        /// </summary>
        [XmlElement("creditor_iban")]
        public string CreditorIban { get; set; }

        /// <summary>
        /// 收款行机构简称
        /// </summary>
        [XmlElement("creditor_inst_abbr")]
        public string CreditorInstAbbr { get; set; }

        /// <summary>
        /// 收款银行两位国家代码；收款渠道为银行必填
        /// </summary>
        [XmlElement("creditor_inst_country_code")]
        public string CreditorInstCountryCode { get; set; }

        /// <summary>
        /// 收款方银行名称
        /// </summary>
        [XmlElement("creditor_inst_name")]
        public string CreditorInstName { get; set; }

        /// <summary>
        /// 收款人邮编
        /// </summary>
        [XmlElement("creditor_post_code")]
        public string CreditorPostCode { get; set; }

        /// <summary>
        /// 收款渠道为银行，收款方为境外有洲的国家/地区对应的城市，如：Henderson(美国内华达州东南克拉克县（Clark）的一个城市)
        /// </summary>
        [XmlElement("creditor_town_name")]
        public string CreditorTownName { get; set; }

        /// <summary>
        /// B：对公，C：对私
        /// </summary>
        [XmlElement("creditor_type")]
        public string CreditorType { get; set; }

        /// <summary>
        /// 付款方财务机构ID，如：Z50、Z51
        /// </summary>
        [XmlElement("debtor_fin_inst_id")]
        public string DebtorFinInstId { get; set; }

        /// <summary>
        /// 非空，使用该字段区分报销、采购等业务，bizCode
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 期望付款时间
        /// </summary>
        [XmlElement("expect_payment_date")]
        public string ExpectPaymentDate { get; set; }

        /// <summary>
        /// 银行渠道中国资金出境需要填写的 国际收支平衡表
        /// </summary>
        [XmlElement("open_api_bop_transaction_code")]
        public string OpenApiBopTransactionCode { get; set; }

        /// <summary>
        /// 境外收支交易编码说明
        /// </summary>
        [XmlElement("open_api_bop_transaction_code_remark")]
        public string OpenApiBopTransactionCodeRemark { get; set; }

        /// <summary>
        /// 收款金额，具体单位'元'
        /// </summary>
        [XmlElement("open_api_instructed_amount")]
        public string OpenApiInstructedAmount { get; set; }

        /// <summary>
        /// 收款金额币种值，例如：人民币对应CNY
        /// </summary>
        [XmlElement("open_api_instructed_amount_currency_code")]
        public string OpenApiInstructedAmountCurrencyCode { get; set; }

        /// <summary>
        /// 业务参考号，必填
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 付款目的，收款币种为 KRW、TWD、MYR时必填，如：返佣服务费
        /// </summary>
        [XmlElement("payment_purpose")]
        public string PaymentPurpose { get; set; }

        /// <summary>
        /// 非空，使用该字段区分报销、采购等业务，bizCode
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 来源，一般为系统名称
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 租户id，必传
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 贷/借；CREDIT/DEBIT
        /// </summary>
        [XmlElement("trans_direction")]
        public string TransDirection { get; set; }

        /// <summary>
        /// 中转行-swiftcode；境外可传
        /// </summary>
        [XmlElement("transmitting_bank")]
        public string TransmittingBank { get; set; }

        /// <summary>
        /// 附言
        /// </summary>
        [XmlElement("unstructured")]
        public string Unstructured { get; set; }
    }
}
