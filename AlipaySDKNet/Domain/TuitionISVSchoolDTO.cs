using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVSchoolDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVSchoolDTO : AopObject
    {
        /// <summary>
        /// 2位国家码
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 学校id
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }
    }
}
