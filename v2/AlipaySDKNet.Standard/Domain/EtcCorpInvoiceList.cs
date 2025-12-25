using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EtcCorpInvoiceList Data Structure.
    /// </summary>
    [Serializable]
    public class EtcCorpInvoiceList : AopObject
    {
        /// <summary>
        /// 购方名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 发票失败原因
        /// </summary>
        [XmlElement("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票开具时间
        /// </summary>
        [XmlElement("invoice_make_time")]
        public string InvoiceMakeTime { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_num")]
        public string InvoiceNum { get; set; }

        /// <summary>
        /// 发票地址下载
        /// </summary>
        [XmlElement("invoice_oss_url")]
        public string InvoiceOssUrl { get; set; }

        /// <summary>
        /// 开票失败
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 是否红票
        /// </summary>
        [XmlElement("invoice_type")]
        public bool InvoiceType { get; set; }

        /// <summary>
        /// 合计金额,单位:分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 合计税额,单位:分
        /// </summary>
        [XmlElement("total_tax_amount")]
        public string TotalTaxAmount { get; set; }
    }
}
