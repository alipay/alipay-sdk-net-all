using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryProfileDTO Data Structure.
    /// </summary>
    [Serializable]
    public class QueryProfileDTO : AopObject
    {
        /// <summary>
        /// 是否有档案
        /// </summary>
        [XmlElement("has_profile")]
        public bool HasProfile { get; set; }

        /// <summary>
        /// 识别标识
        /// </summary>
        [XmlElement("mark_id")]
        public string MarkId { get; set; }
    }
}
