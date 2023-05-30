using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContactInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class ContactInfoVO : AopObject
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人信息加密内容
        /// </summary>
        [XmlElement("encryption_content")]
        public string EncryptionContent { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
