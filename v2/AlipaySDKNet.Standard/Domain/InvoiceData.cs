using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceData Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceData : AopObject
    {
        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("buyer_invoice_title")]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 发票所属机构id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 发票金额，单位：元
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票金额币种
        /// </summary>
        [XmlElement("invoice_amount_currency")]
        public string InvoiceAmountCurrency { get; set; }

        /// <summary>
        /// 发票申请日期
        /// </summary>
        [XmlElement("invoice_apply_date")]
        public string InvoiceApplyDate { get; set; }

        /// <summary>
        /// 发票唯一编码
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票开具日期
        /// </summary>
        [XmlElement("invoice_open_date")]
        public string InvoiceOpenDate { get; set; }

        /// <summary>
        /// 发票状态
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票邮寄状态
        /// </summary>
        [XmlElement("mail_status")]
        public string MailStatus { get; set; }

        /// <summary>
        /// 开放平台id
        /// </summary>
        [XmlElement("open_api_id")]
        public string OpenApiId { get; set; }

        /// <summary>
        /// 发票邮寄下载地址
        /// </summary>
        [XmlElement("out_side_download_url")]
        public string OutSideDownloadUrl { get; set; }
    }
}
