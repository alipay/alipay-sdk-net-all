using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SchoolCardSimpleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SchoolCardSimpleInfo : AopObject
    {
        /// <summary>
        /// 支付宝学校编码
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校标识码
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// isv分配的学生短码
        /// </summary>
        [XmlElement("short_code")]
        public string ShortCode { get; set; }

        /// <summary>
        /// 支付宝校园卡状态，0:有效，1:无效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
