using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceIssuerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceIssuerInfo : AopObject
    {
        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("cashier_name")]
        public string CashierName { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [XmlElement("checker_name")]
        public string CheckerName { get; set; }

        /// <summary>
        /// 开票员证件号码
        /// </summary>
        [XmlElement("invoice_clerk_certificate_no")]
        public string InvoiceClerkCertificateNo { get; set; }

        /// <summary>
        /// 开票员证件类型.居民身份证201
        /// </summary>
        [XmlElement("invoice_clerk_certificate_type")]
        public string InvoiceClerkCertificateType { get; set; }

        /// <summary>
        /// 开票人或开票员
        /// </summary>
        [XmlElement("invoice_issuer")]
        public string InvoiceIssuer { get; set; }
    }
}
