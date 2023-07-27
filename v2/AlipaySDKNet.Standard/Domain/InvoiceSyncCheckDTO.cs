using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceSyncCheckDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceSyncCheckDTO : AopObject
    {
        /// <summary>
        /// ou代码
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 校验码,专票传空
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Y:全电票,N:非全电票
        /// </summary>
        [XmlElement("full_electronic_flag")]
        public string FullElectronicFlag { get; set; }

        /// <summary>
        /// 价税合计,单位元,两位小数
        /// </summary>
        [XmlElement("invoice_amt")]
        public string InvoiceAmt { get; set; }

        /// <summary>
        /// 发票代码，全电票传空
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期，格式yyyyMMdd
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 税额,单位元,两位小数
        /// </summary>
        [XmlElement("tax_amt")]
        public string TaxAmt { get; set; }
    }
}
