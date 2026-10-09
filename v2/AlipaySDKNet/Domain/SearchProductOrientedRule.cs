using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchProductOrientedRule Data Structure.
    /// </summary>
    [Serializable]
    public class SearchProductOrientedRule : AopObject
    {
        /// <summary>
        /// 客户端
        /// </summary>
        [XmlElement("client_platform")]
        public string ClientPlatform { get; set; }

        /// <summary>
        /// 结束版本
        /// </summary>
        [XmlElement("end_version")]
        public string EndVersion { get; set; }

        /// <summary>
        /// 开始版本
        /// </summary>
        [XmlElement("start_version")]
        public string StartVersion { get; set; }
    }
}
