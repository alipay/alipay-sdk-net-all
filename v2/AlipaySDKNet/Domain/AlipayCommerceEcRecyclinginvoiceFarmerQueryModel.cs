using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceFarmerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceFarmerQueryModel : AopObject
    {
        /// <summary>
        /// 农户身份证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 农户ID
        /// </summary>
        [XmlElement("farmer_id")]
        public string FarmerId { get; set; }

        /// <summary>
        /// 代卖?身份证件号
        /// </summary>
        [XmlElement("proxy_cert_no")]
        public string ProxyCertNo { get; set; }
    }
}
