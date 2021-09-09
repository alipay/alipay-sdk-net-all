using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainTwcCertifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainTwcCertifyQueryModel : AopObject
    {
        /// <summary>
        /// 实人认证的id
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
