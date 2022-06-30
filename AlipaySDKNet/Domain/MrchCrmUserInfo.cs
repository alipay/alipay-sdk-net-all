using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MrchCrmUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MrchCrmUserInfo : AopObject
    {
        /// <summary>
        /// 密文邮箱 <p> 加密方式：sha256(邮箱明文) </p> <p> 注意：encrypt_mobile 与encrypt_email不会同时为空,encrypt_mobile不为空时优先通过encrypt_mobile匹配； </p>
        /// </summary>
        [XmlElement("encrypt_email")]
        public string EncryptEmail { get; set; }

        /// <summary>
        /// 密文手机号码 <p> 加密方式：sha256(手机号码明文) </p> <p> 注意：encrypt_mobile 与encrypt_email不会同时为空,encrypt_mobile不为空时优先通过encrypt_mobile匹配； </p>
        /// </summary>
        [XmlElement("encrypt_mobile")]
        public string EncryptMobile { get; set; }

        /// <summary>
        /// 商家用户标签
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("mrch_crm_user_tag_info")]
        public List<MrchCrmUserTagInfo> TagList { get; set; }
    }
}
