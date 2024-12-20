using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassportCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassportCreateModel : AopObject
    {
        /// <summary>
        /// 登录凭证 取值为加密后的登录凭证值
        /// </summary>
        [XmlElement("credential")]
        public string Credential { get; set; }

        /// <summary>
        /// 邮箱 取值为加密后的邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 阿里云精选买家
        /// </summary>
        [XmlElement("entity_role_type")]
        public string EntityRoleType { get; set; }

        /// <summary>
        /// 手机号  取值为加密后的手机号码
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }
    }
}
