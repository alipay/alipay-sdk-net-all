using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceButtonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceButtonInfo : AopObject
    {
        /// <summary>
        /// 服务图标
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务开关
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 服务链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
