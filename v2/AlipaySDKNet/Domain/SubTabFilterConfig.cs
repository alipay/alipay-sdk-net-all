using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubTabFilterConfig Data Structure.
    /// </summary>
    [Serializable]
    public class SubTabFilterConfig : AopObject
    {
        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("min_version_code")]
        public string MinVersionCode { get; set; }

        /// <summary>
        /// 排行榜数据类型
        /// </summary>
        [XmlElement("rank_data_type")]
        public string RankDataType { get; set; }

        /// <summary>
        /// 子排行类型列表
        /// </summary>
        [XmlArray("sub_rank_type_list")]
        [XmlArrayItem("sub_rank_tab_filter_config")]
        public List<SubRankTabFilterConfig> SubRankTypeList { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 冬测
        /// </summary>
        [XmlElement("winter_eval")]
        public string WinterEval { get; set; }
    }
}
