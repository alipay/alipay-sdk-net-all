using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SchoolCard Data Structure.
    /// </summary>
    [Serializable]
    public class SchoolCard : AopObject
    {
        /// <summary>
        /// 学生姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 开通状态
        /// </summary>
        [XmlElement("protocol_status")]
        public string ProtocolStatus { get; set; }

        /// <summary>
        /// 开通成功，返回的schema
        /// </summary>
        [XmlElement("schema_url")]
        public string SchemaUrl { get; set; }

        /// <summary>
        /// 学校内标，一般为2088开头的16位数字。支付宝分配，可直接咨询支付宝对接小二，也可通过开放平台接口查询
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 同学校分配给某学生的唯一标识，可以是学号、一卡通卡号等
        /// </summary>
        [XmlElement("student_id")]
        public string StudentId { get; set; }
    }
}
