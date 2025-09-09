using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RelatedPerson Data Structure.
    /// </summary>
    [Serializable]
    public class RelatedPerson : AopObject
    {
        /// <summary>
        /// 投保人年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 投保人生日 YYYY-MM-DD
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 投保人证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 投保人证件类型，枚举值
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 投保人邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 投保人性别，枚举值
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 有无社保
        /// </summary>
        [XmlElement("join_social_security")]
        public string JoinSocialSecurity { get; set; }

        /// <summary>
        /// 投保人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 干系人类型，枚举值
        /// </summary>
        [XmlElement("person_type")]
        public string PersonType { get; set; }

        /// <summary>
        /// 投保人联系方式
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 与投保人关系，枚举值
        /// </summary>
        [XmlElement("relation_to_holder")]
        public string RelationToHolder { get; set; }
    }
}
