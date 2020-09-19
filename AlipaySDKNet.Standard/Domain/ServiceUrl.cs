using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceUrl Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceUrl : AopObject
    {
        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
