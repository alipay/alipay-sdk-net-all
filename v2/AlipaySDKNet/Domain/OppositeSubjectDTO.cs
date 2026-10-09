using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OppositeSubjectDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OppositeSubjectDTO : AopObject
    {
        /// <summary>
        /// 对方信息备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 对方联系地址
        /// </summary>
        [XmlElement("opposite_contact_addr")]
        public string OppositeContactAddr { get; set; }

        /// <summary>
        /// 对方联系邮箱
        /// </summary>
        [XmlElement("opposite_contact_email")]
        public string OppositeContactEmail { get; set; }

        /// <summary>
        /// 对方联系人姓名
        /// </summary>
        [XmlElement("opposite_contact_name")]
        public string OppositeContactName { get; set; }

        /// <summary>
        /// 对方联系电话
        /// </summary>
        [XmlElement("opposite_contact_phone")]
        public string OppositeContactPhone { get; set; }

        /// <summary>
        /// 对方公司名称
        /// </summary>
        [XmlElement("opposite_subject_name")]
        public string OppositeSubjectName { get; set; }

        /// <summary>
        /// 对方Uscc
        /// </summary>
        [XmlElement("opposite_uscc")]
        public string OppositeUscc { get; set; }
    }
}
