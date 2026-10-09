using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubTestDesensitive Data Structure.
    /// </summary>
    [Serializable]
    public class SubTestDesensitive : AopObject
    {
        /// <summary>
        /// 邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 邮箱列表
        /// </summary>
        [XmlArray("email_list")]
        [XmlArrayItem("string")]
        public List<string> EmailList { get; set; }

        /// <summary>
        /// 是否是学生
        /// </summary>
        [XmlElement("is_student")]
        public string IsStudent { get; set; }

        /// <summary>
        /// ["T","T","T"]
        /// </summary>
        [XmlArray("is_student_list")]
        [XmlArrayItem("string")]
        public List<string> IsStudentList { get; set; }

        /// <summary>
        /// 1200
        /// </summary>
        [XmlElement("school")]
        public string School { get; set; }
    }
}
