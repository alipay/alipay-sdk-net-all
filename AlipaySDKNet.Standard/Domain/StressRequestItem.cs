using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StressRequestItem Data Structure.
    /// </summary>
    [Serializable]
    public class StressRequestItem : AopObject
    {
        /// <summary>
        /// 资源名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 资源大小，单位是B
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 请求时间，单位是 ms
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
