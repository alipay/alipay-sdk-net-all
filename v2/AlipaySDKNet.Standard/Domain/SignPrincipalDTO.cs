using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignPrincipalDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SignPrincipalDTO : AopObject
    {
        /// <summary>
        /// 签约主体身份标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 签约主体身份标识类型，有限枚举， IDENTITY_CARD：身份证号
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 签约主体名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 签约主体手机号码
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
