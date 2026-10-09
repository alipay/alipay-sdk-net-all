using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyPersonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyPersonInfo : AopObject
    {
        /// <summary>
        /// 干系人证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 干系人证件类型 01 身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 干系人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 干系人类型 HOLDER  投保人 INSURED  被保人
        /// </summary>
        [XmlElement("person_type")]
        public string PersonType { get; set; }

        /// <summary>
        /// 干系人联系方式
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 与投保人关系 1 本人 2 配偶 3 父母 4 子女 5 其他
        /// </summary>
        [XmlElement("relation_to_holder")]
        public string RelationToHolder { get; set; }
    }
}
