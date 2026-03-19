using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Faculty Data Structure.
    /// </summary>
    [Serializable]
    public class Faculty : AopObject
    {
        /// <summary>
        /// 专业方向ID
        /// </summary>
        [XmlElement("faculty_id")]
        public string FacultyId { get; set; }

        /// <summary>
        /// 专业方向名称
        /// </summary>
        [XmlElement("faculty_name")]
        public string FacultyName { get; set; }
    }
}
