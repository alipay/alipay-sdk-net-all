using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourceDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniResourceDataQueryModel : AopObject
    {
        /// <summary>
        /// 插件appId
        /// </summary>
        [XmlElement("plugin_id")]
        public string PluginId { get; set; }

        /// <summary>
        /// 数据日期，格式为yyyyMMdd
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 创建流量位时返回的流量位id
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}
