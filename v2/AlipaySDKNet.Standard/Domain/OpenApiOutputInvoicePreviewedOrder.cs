using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiOutputInvoicePreviewedOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiOutputInvoicePreviewedOrder : AopObject
    {
        /// <summary>
        /// 发票购方公司的注册地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 发票购方的开户行银行账号信息
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 发票购方的公司开户行银行名称
        /// </summary>
        [XmlElement("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 发票购方的公司名称
        /// </summary>
        [XmlElement("buyer_invoice_title")]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 购方PID
        /// </summary>
        [XmlElement("buyer_ip_role_id")]
        public string BuyerIpRoleId { get; set; }

        /// <summary>
        /// 发票购方的MID
        /// </summary>
        [XmlElement("buyer_mid")]
        public string BuyerMid { get; set; }

        /// <summary>
        /// 发票购方的税号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 发票购方公司的联系电话信息
        /// </summary>
        [XmlElement("buyer_telephone")]
        public string BuyerTelephone { get; set; }

        /// <summary>
        /// 发票的开票人信息
        /// </summary>
        [XmlElement("drawer")]
        public string Drawer { get; set; }

        /// <summary>
        /// 发票全电标识
        /// </summary>
        [XmlElement("full_electronic_tag")]
        public string FullElectronicTag { get; set; }

        /// <summary>
        /// 票面金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 开票渠道，线上开具 or 线下开具
        /// </summary>
        [XmlElement("invoice_channel")]
        public string InvoiceChannel { get; set; }

        /// <summary>
        /// 发票代码，发票上标注发票代码的字段
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票的开票日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票id，发票在发票表里的唯一标识
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票对应的发票行信息
        /// </summary>
        [XmlArray("invoice_lines")]
        [XmlArrayItem("open_api_invoice_line_previewed_order")]
        public List<OpenApiInvoiceLinePreviewedOrder> InvoiceLines { get; set; }

        /// <summary>
        /// 发票的介质，电子/纸质
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码，发票上面标注号码的字段
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票上的票面备注信息
        /// </summary>
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 发票状态，预览后申请开票的发票，状态只会为待开票（01）
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票类型，增值税专用发票/增值税普通发票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 该发票能在在线开票
        /// </summary>
        [XmlElement("is_online")]
        public string IsOnline { get; set; }

        /// <summary>
        /// 发票是红票还是蓝票，Y：红票，N：蓝票
        /// </summary>
        [XmlElement("is_red")]
        public string IsRed { get; set; }

        /// <summary>
        /// 发票邮寄状态，预览后申请开票的发票邮寄状态只会为待邮寄（01）
        /// </summary>
        [XmlElement("mail_status")]
        public string MailStatus { get; set; }

        /// <summary>
        /// 开票的备注，区别去票面备注，该字段用于指明开票原因等信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 该发票是否通过无账单开票生成
        /// </summary>
        [XmlElement("no_bill_invoice_flag")]
        public string NoBillInvoiceFlag { get; set; }

        /// <summary>
        /// 发票对应的收款人信息
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 发票对应的，最近一次的邮寄信息id
        /// </summary>
        [XmlElement("recent_mail_id")]
        public string RecentMailId { get; set; }

        /// <summary>
        /// 发票的红冲金额
        /// </summary>
        [XmlElement("red_amt")]
        public MultiCurrencyMoneyOpenApi RedAmt { get; set; }

        /// <summary>
        /// 发票的复核人名字
        /// </summary>
        [XmlElement("reviewer")]
        public string Reviewer { get; set; }

        /// <summary>
        /// 销方公司注册地址
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方银行账号信息
        /// </summary>
        [XmlElement("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销方开户行名称
        /// </summary>
        [XmlElement("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 描述发票的销方公司名称
        /// </summary>
        [XmlElement("seller_company_name")]
        public string SellerCompanyName { get; set; }

        /// <summary>
        /// 发票销方对应的OU编码
        /// </summary>
        [XmlElement("seller_inst_id")]
        public string SellerInstId { get; set; }

        /// <summary>
        /// 销方公司的税号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销方公司注册电话
        /// </summary>
        [XmlElement("seller_telephone")]
        public string SellerTelephone { get; set; }

        /// <summary>
        /// 发票税额
        /// </summary>
        [XmlElement("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 租户信息
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 发票类型，该接口传入的类型只会为OUTPUT（销项票）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
