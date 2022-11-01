using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MrchCrmUser Data Structure.
    /// </summary>
    [Serializable]
    public class MrchCrmUser : AopObject
    {
        /// <summary>
        /// 用户身份信息密文，加密方式如下： 当encrypt_identity_type = 'mobile'时 encrypt_identity_id = sha256(手机号码); 当encrypt_identity_type = 'email'时 encrypt_identity_id = sha256(邮箱)
        /// </summary>
        [XmlElement("encrypt_identity_id")]
        public string EncryptIdentityId { get; set; }

        /// <summary>
        /// 用户身份信息类型-手机号、邮箱，枚举如下： mobile-手机号码，email-邮箱
        /// </summary>
        [XmlElement("encrypt_identity_type")]
        public string EncryptIdentityType { get; set; }

        /// <summary>
        /// 用户标签信息
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("mrch_crm_user_tag_info")]
        public List<MrchCrmUserTagInfo> TagList { get; set; }
    }
}
