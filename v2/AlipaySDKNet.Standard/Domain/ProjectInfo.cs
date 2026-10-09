using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProjectInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProjectInfo : AopObject
    {
        /// <summary>
        /// 权益终止时间，格式YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 履约权益编码
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 权益生效时间，格式yyyy-mm-dd hh:MM:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
