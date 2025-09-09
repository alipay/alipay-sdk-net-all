using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyInvoiceClerk Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyInvoiceClerk : AopObject
    {
        /// <summary>
        /// 开票员证件号码
        /// </summary>
        [XmlElement("clerk_cert_no")]
        public string ClerkCertNo { get; set; }

        /// <summary>
        /// 开票员姓名
        /// </summary>
        [XmlElement("clerk_name")]
        public string ClerkName { get; set; }

        /// <summary>
        /// 开票员身份标识
        /// </summary>
        [XmlElement("clerk_no")]
        public string ClerkNo { get; set; }
    }
}
