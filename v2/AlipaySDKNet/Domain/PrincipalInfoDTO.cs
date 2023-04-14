using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrincipalInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PrincipalInfoDTO : AopObject
    {
        /// <summary>
        /// 签约开通商户主体
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 签约开通商户主体名称
        /// </summary>
        [XmlElement("identity_name")]
        public string IdentityName { get; set; }

        /// <summary>
        /// 签约开通商户主体类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }
    }
}
