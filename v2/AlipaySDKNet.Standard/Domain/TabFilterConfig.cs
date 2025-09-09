using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TabFilterConfig Data Structure.
    /// </summary>
    [Serializable]
    public class TabFilterConfig : AopObject
    {
        /// <summary>
        /// 背景图
        /// </summary>
        [XmlElement("background_img")]
        public string BackgroundImg { get; set; }

        /// <summary>
        /// banner
        /// </summary>
        [XmlElement("banner")]
        public Banner Banner { get; set; }

        /// <summary>
        /// 数据统计
        /// </summary>
        [XmlElement("data_count")]
        public DataCount DataCount { get; set; }

        /// <summary>
        /// 最小版本
        /// </summary>
        [XmlElement("min_version_code")]
        public string MinVersionCode { get; set; }

        /// <summary>
        /// 排行类型
        /// </summary>
        [XmlElement("rank_data_type")]
        public string RankDataType { get; set; }

        /// <summary>
        /// 子tag列表
        /// </summary>
        [XmlArray("sub_tab_list")]
        [XmlArrayItem("sub_tab_filter_config")]
        public List<SubTabFilterConfig> SubTabList { get; set; }

        /// <summary>
        /// 子tab数据列表2
        /// </summary>
        [XmlArray("sub_tab_list_v2")]
        [XmlArrayItem("sub_tab_filter_config")]
        public List<SubTabFilterConfig> SubTabListV2 { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [XmlElement("tag")]
        public TabFilterTag Tag { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
