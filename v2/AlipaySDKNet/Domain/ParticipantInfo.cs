using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantInfo : AopObject
    {
        /// <summary>
        /// 参赛者常用地址
        /// </summary>
        [XmlElement("contact_address")]
        public string ContactAddress { get; set; }

        /// <summary>
        /// 参赛者当前学校
        /// </summary>
        [XmlElement("current_school")]
        public string CurrentSchool { get; set; }

        /// <summary>
        /// 参赛者邮箱
        /// </summary>
        [XmlElement("e_mail")]
        public string EMail { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 参赛者名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 参赛者照片链接
        /// </summary>
        [XmlElement("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// 参赛者性别
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 参赛者联系方式
        /// </summary>
        [XmlElement("tel_number")]
        public string TelNumber { get; set; }
    }
}
