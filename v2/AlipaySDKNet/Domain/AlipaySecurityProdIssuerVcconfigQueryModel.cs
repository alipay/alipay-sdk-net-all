using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdIssuerVcconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdIssuerVcconfigQueryModel : AopObject
    {
        /// <summary>
        /// 分布式认证体系下的凭证类型
        /// </summary>
        [XmlElement("credential_type")]
        public string CredentialType { get; set; }

        /// <summary>
        /// 颁发方调用sdk拌饭凭证时，出入自己的did标识
        /// </summary>
        [XmlElement("issuer_did")]
        public string IssuerDid { get; set; }
    }
}
