using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductUsageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductUsageInfo : AopObject
    {
        /// <summary>
        /// 展示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 计费项详情列表
        /// </summary>
        [XmlArray("fee_item_infos")]
        [XmlArrayItem("fee_item_info")]
        public List<FeeItemInfo> FeeItemInfos { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
