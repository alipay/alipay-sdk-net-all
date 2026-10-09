using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ValidateUserPrincipal Data Structure.
    /// </summary>
    [Serializable]
    public class ValidateUserPrincipal : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("principal_cert_no")]
        public string PrincipalCertNo { get; set; }

        /// <summary>
        /// 校验的主体名称，如：个人名称、企业名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }
    }
}
