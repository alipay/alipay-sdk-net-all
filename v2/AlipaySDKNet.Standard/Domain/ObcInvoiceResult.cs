using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObcInvoiceResult Data Structure.
    /// </summary>
    [Serializable]
    public class ObcInvoiceResult : AopObject
    {
        /// <summary>
        /// 币种code，国内为CNY固定值
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 下载链接
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 发票单id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 发票金额，当币种为CNY时，单位为分
        /// </summary>
        [XmlElement("invoice_amt")]
        public long InvoiceAmt { get; set; }

        /// <summary>
        /// 发票code
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票票面上的开具日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 票面的状态
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 是否红票
        /// </summary>
        [XmlElement("red_flag")]
        public bool RedFlag { get; set; }

        /// <summary>
        /// 已红冲的金额，当币种为CNY时，单位为分
        /// </summary>
        [XmlElement("redeem_amt")]
        public long RedeemAmt { get; set; }
    }
}
