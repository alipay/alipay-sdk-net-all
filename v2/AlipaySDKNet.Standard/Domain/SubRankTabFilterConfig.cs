using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubRankTabFilterConfig Data Structure.
    /// </summary>
    [Serializable]
    public class SubRankTabFilterConfig : AopObject
    {
        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("min_version_code")]
        public string MinVersionCode { get; set; }

        /// <summary>
        /// 排行数据类型
        /// </summary>
        [XmlElement("rank_data_type")]
        public string RankDataType { get; set; }

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
