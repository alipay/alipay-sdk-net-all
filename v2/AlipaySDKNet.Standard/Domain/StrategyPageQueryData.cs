using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StrategyPageQueryData Data Structure.
    /// </summary>
    [Serializable]
    public class StrategyPageQueryData : AopObject
    {
        /// <summary>
        /// 纠错词
        /// </summary>
        [XmlElement("correct_words")]
        public string CorrectWords { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 过滤词
        /// </summary>
        [XmlElement("filter_words")]
        public string FilterWords { get; set; }

        /// <summary>
        /// 数据总条数
        /// </summary>
        [XmlElement("items")]
        public long Items { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 列表页结构定义
        /// </summary>
        [XmlElement("page_structure")]
        public StrategyPageStructure PageStructure { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("value")]
        [XmlArrayItem("string")]
        public List<string> Value { get; set; }
    }
}
