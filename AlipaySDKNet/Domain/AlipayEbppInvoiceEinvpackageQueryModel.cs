using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEinvpackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceEinvpackageQueryModel : AopObject
    {
        /// <summary>
        /// 加密过的uid
        /// </summary>
        [XmlElement("encrypted_uid")]
        public string EncryptedUid { get; set; }

        /// <summary>
        /// 发票包id
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }
    }
}
