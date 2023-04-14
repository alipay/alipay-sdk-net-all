using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutputInvoiceReceiptOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OutputInvoiceReceiptOpenApiResponse : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 是否可以指定开票模式
        /// </summary>
        [XmlElement("can_appoint_invoice_mode")]
        public bool CanAppointInvoiceMode { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票时间 格式：yyyymm
        /// </summary>
        [XmlElement("inv_dt")]
        public string InvDt { get; set; }

        /// <summary>
        /// 开票模式 01：实收开票， 02：应收开票
        /// </summary>
        [XmlElement("inv_mode")]
        public string InvMode { get; set; }

        /// <summary>
        /// 可开票金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 已开票金额
        /// </summary>
        [XmlElement("invoiced_amt")]
        public MultiCurrencyMoneyOpenApi InvoicedAmt { get; set; }

        /// <summary>
        /// 结算ip_id
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 结算对象ip_role_id
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 已关联发票金额
        /// </summary>
        [XmlElement("link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi LinkInvoiceAmt { get; set; }

        /// <summary>
        /// 外部单据号，对应开票记录的月账单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 可开票单据来源，01：主站，02：芝麻，03：金融云，04
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 账单确认金额 canAppointInvoiceMode=true时，可使用该金额作为应收开票模式的金额
        /// </summary>
        [XmlElement("receivable_amount")]
        public MultiCurrencyMoneyOpenApi ReceivableAmount { get; set; }

        /// <summary>
        /// 结算类型 ，01：实时，02：预收，03：后收，04：周期性，05：按日汇总，09：延期结算
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 开票金额消耗状态：01未开票，02部分开票，03：已开票
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税收类型01：增值税，02：营业税
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 核销金额 canAppointInvoiceMode=true时，可使用该金额作为实收开票模式的金额
        /// </summary>
        [XmlElement("write_off_amount")]
        public MultiCurrencyMoneyOpenApi WriteOffAmount { get; set; }
    }
}
