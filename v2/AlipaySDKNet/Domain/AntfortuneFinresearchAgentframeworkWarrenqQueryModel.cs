using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchAgentframeworkWarrenqQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchAgentframeworkWarrenqQueryModel : AopObject
    {
        /// <summary>
        /// 要执行的query
        /// </summary>
        [XmlElement("input")]
        public string Input { get; set; }

        /// <summary>
        /// 所请求的agent服务ID
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 要检索的文档
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }
    }
}
