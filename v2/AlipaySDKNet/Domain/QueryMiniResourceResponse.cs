using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QueryMiniResourceResponse Data Structure.
    /// </summary>
    [Serializable]
    public class QueryMiniResourceResponse : AopObject
    {
        /// <summary>
        /// 端
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 流量位模式 CPS
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 流量位名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 流量位id
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 广告展示列数
        /// </summary>
        [XmlElement("row_num")]
        public string RowNum { get; set; }

        /// <summary>
        /// 流量位规则列表
        /// </summary>
        [XmlArray("rule_list")]
        [XmlArrayItem("mini_resource_rule")]
        public List<MiniResourceRule> RuleList { get; set; }

        /// <summary>
        /// 广告展示个数
        /// </summary>
        [XmlElement("show_num")]
        public string ShowNum { get; set; }

        /// <summary>
        /// 流量位类型 INFORMATION: 信息流
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
