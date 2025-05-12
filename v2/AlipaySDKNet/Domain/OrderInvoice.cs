using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderInvoice Data Structure.
    /// </summary>
    [Serializable]
    public class OrderInvoice : AopObject
    {
        /// <summary>
        /// 发票图片下载地址
        /// </summary>
        [XmlElement("img_file_url")]
        public string ImgFileUrl { get; set; }

        /// <summary>
        /// 发票不含税金额（元，两位小数）
        /// </summary>
        [XmlElement("invoice_amount_without_tax")]
        public string InvoiceAmountWithoutTax { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 开票状态信息
        /// </summary>
        [XmlElement("invoice_status_message")]
        public string InvoiceStatusMessage { get; set; }

        /// <summary>
        /// 发票税额（元，两位小数）
        /// </summary>
        [XmlElement("invoice_tax_amount")]
        public string InvoiceTaxAmount { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 发票PDF下载地址
        /// </summary>
        [XmlElement("pdf_file_url")]
        public string PdfFileUrl { get; set; }
    }
}
