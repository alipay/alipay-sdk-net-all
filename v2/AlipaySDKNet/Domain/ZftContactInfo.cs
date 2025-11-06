using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZftContactInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZftContactInfo : AopObject
    {
        /// <summary>
        /// 电子邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_card_no")]
        public string IdCardNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
