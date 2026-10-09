using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeLinenetworkversionQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeLinenetworkversionQueryResponse : AopResponse
    {
        /// <summary>
        /// 扩展字段,双方约定取值
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 线网版本号
        /// </summary>
        [XmlElement("linenet_version")]
        public string LinenetVersion { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 版本时间
        /// </summary>
        [XmlElement("version_time")]
        public string VersionTime { get; set; }
    }
}
