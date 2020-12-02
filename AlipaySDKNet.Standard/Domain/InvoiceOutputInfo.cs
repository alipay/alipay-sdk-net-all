using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceOutputInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceOutputInfo : AopObject
    {
        /// <summary>
        /// 发票防伪码，验证码
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
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票明细项。
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
        /// 发票预览图片地址
        /// </summary>
        [XmlElement("invoice_img_url")]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 标识发票的类型，PLAIN:增值税电子普通发票;SPECIAL:增值税专用发票;PLAIN_INVOICE:增值税普通发票;SALSE_INVOICE:机动车销售统一发票 ;PAPER_INVOICE:增值税普通发票(卷式)。
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 票面上备注信息。
        /// </summary>
        [XmlElement("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票抬头，票面上的购买方信息。
        /// </summary>
        [XmlElement("invoice_title")]
        public InvoiceTitleOpenModel InvoiceTitle { get; set; }

        /// <summary>
        /// 标识是红票还是蓝票，RED:红票;BLUE:蓝票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票代码。
        /// </summary>
        [XmlElement("ori_blue_inv_code")]
        public string OriBlueInvCode { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票号码。
        /// </summary>
        [XmlElement("ori_blue_inv_no")]
        public string OriBlueInvNo { get; set; }

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
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

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
