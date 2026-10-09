using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessContactDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessContactDTO : AopObject
    {
        /// <summary>
        /// 联系人地址
        /// </summary>
        [XmlElement("contact_address")]
        public BusinessAddressDTO ContactAddress { get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 联系人手机
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 座机号码
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 联系人职位
        /// </summary>
        [XmlElement("contact_position")]
        public string ContactPosition { get; set; }

        /// <summary>
        /// 联系人类型
        /// </summary>
        [XmlElement("contact_type")]
        public string ContactType { get; set; }
    }
}
