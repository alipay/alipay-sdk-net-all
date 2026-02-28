using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvEmailInvoiceFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvEmailInvoiceFileInfo : AopObject
    {
        /// <summary>
        /// 发票文件下载地址
        /// </summary>
        [XmlElement("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 发票文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 发票文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 价税合计金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票票种类型
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方抬头税号
        /// </summary>
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("without_tax_amount")]
        public string WithoutTaxAmount { get; set; }
    }
}
