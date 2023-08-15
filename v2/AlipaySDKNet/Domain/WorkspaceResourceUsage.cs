using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkspaceResourceUsage Data Structure.
    /// </summary>
    [Serializable]
    public class WorkspaceResourceUsage : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 产品下各计费项用量详情列表
        /// </summary>
        [XmlArray("product_usage_infos")]
        [XmlArrayItem("product_usage_info")]
        public List<ProductUsageInfo> ProductUsageInfos { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
