using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceSendOpenByAlipayTradeNo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceSendOpenByAlipayTradeNo : AopObject
    {
        /// <summary>
        /// 票面上的校验码信息。
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 票面上复核人信息。
        /// </summary>
        [XmlElement("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 票面上开票员信息。
        /// </summary>
        [XmlElement("clerk")]
        public string Clerk { get; set; }

        /// <summary>
        /// 不含税金额，票面上的不含税金额，单位（元），保留两位小数。
        /// </summary>
        [XmlElement("ex_tax_amount")]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 预留的扩展字段，格式如：key1=value1\nkey2=value2\nkey3=value3，字段之间以\n分隔。
        /// </summary>
        [XmlElement("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 下载版式文件类型，需要回传文件下载链接的情况下必传
        /// </summary>
        [XmlElement("file_download_type")]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 发票版式文件下载地址。
        /// </summary>
        [XmlElement("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 财政电子票据子类型
        /// </summary>
        [XmlElement("financial_electronic_type")]
        public string FinancialElectronicType { get; set; }

        /// <summary>
        /// 发票代码，该字段与invoice_no构成一张发票的唯一标识。
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票明细项
        /// </summary>
        [XmlArray("invoice_content")]
        [XmlArrayItem("invoice_item_open_model")]
        public List<InvoiceItemOpenModel> InvoiceContent { get; set; }

        /// <summary>
        /// 开票日期，格式如：YYYY-MM-DD。
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 标识发票的类型， PLAIN:增值税电子普通发票; SPECIAL:增值税专用发票; ALL_ELECTRONIC_GENERAL:电子发票（普通发票）; ALL_ELECTRONIC_SPECIAL:电子发票（增值税专用发票）; PLAIN_INVOICE:增值税普通发票; FINANCIAL_ELECTRONIC_BILL:财政电子票据;
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 票面上备注信息。
        /// </summary>
        [XmlElement("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码，该字段与invoice_code构成一张发票的唯一标识。
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("invoice_title")]
        public InvoiceTitleOpenModel InvoiceTitle { get; set; }

        /// <summary>
        /// 标识是红票还是蓝票，RED:红票;BLUE:蓝票。
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票代码（全电票时为空）。
        /// </summary>
        [XmlElement("ori_blue_inv_code")]
        public string OriBlueInvCode { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票号码。
        /// </summary>
        [XmlElement("ori_blue_inv_no")]
        public string OriBlueInvNo { get; set; }

        /// <summary>
        /// 外部发票id，isv生成发票之后所生成的发票流水号，主要用做存储。
        /// </summary>
        [XmlElement("out_invoice_id")]
        public string OutInvoiceId { get; set; }

        /// <summary>
        /// 外部商户交易流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 票面上收款人信息。
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 票面上销售方地址、电话信息。
        /// </summary>
        [XmlElement("payee_address_tel")]
        public string PayeeAddressTel { get; set; }

        /// <summary>
        /// 票面上销售方开户行及账号。
        /// </summary>
        [XmlElement("payee_bank_name_account")]
        public string PayeeBankNameAccount { get; set; }

        /// <summary>
        /// 票面上销售方企业名称。
        /// </summary>
        [XmlElement("payee_register_name")]
        public string PayeeRegisterName { get; set; }

        /// <summary>
        /// 票面上销售方税号信息。
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 价税合计，票面上的总开票金额，单位（元），保留两位小数，sum_amount=ex_tax_amount+tax_amount。
        /// </summary>
        [XmlElement("sum_amount")]
        public string SumAmount { get; set; }

        /// <summary>
        /// 合计税额，票面上的合计税额，单位（元），保留两位小数。
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }
    }
}
