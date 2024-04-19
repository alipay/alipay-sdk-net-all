using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScheduleResItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScheduleResItem : AopObject
    {
        /// <summary>
        /// 资源标志
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
