using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UpdateContactRequest Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateContactRequest : AopObject
    {
        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 联系人职位
        /// </summary>
        [XmlElement("job_title")]
        public string JobTitle { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
