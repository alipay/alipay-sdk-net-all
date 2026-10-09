using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IdentityDTO Data Structure.
    /// </summary>
    [Serializable]
    public class IdentityDTO : AopObject
    {
        /// <summary>
        /// 经办人姓名，企业认证必选
        /// </summary>
        [XmlElement("agent")]
        public string Agent { get; set; }

        /// <summary>
        /// 经办人身份证,企业认证必选
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型1|2|3，个人默认选1表示身份证IDENTITY_CARD，企业可以选2表示 UNIFIED_SOCIAL_CREDIT_CODE（统一社会信用代码）或3表示 ENTERPRISE_REGISTERED_NUMBER（企业工商注册号）
        /// </summary>
        [XmlElement("cert_type")]
        public long CertType { get; set; }

        /// <summary>
        /// 法人姓名，企业认证必选
        /// </summary>
        [XmlElement("legal_person")]
        public string LegalPerson { get; set; }

        /// <summary>
        /// 法人身份证,企业认证必选
        /// </summary>
        [XmlElement("legal_person_id")]
        public string LegalPersonId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 用户类型，1表示个人，2表示企业
        /// </summary>
        [XmlElement("user_type")]
        public long UserType { get; set; }
    }
}
