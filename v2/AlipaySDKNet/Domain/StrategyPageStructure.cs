using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StrategyPageStructure Data Structure.
    /// </summary>
    [Serializable]
    public class StrategyPageStructure : AopObject
    {
        /// <summary>
        /// 批量操作开关
        /// </summary>
        [XmlElement("batch_switch")]
        public string BatchSwitch { get; set; }

        /// <summary>
        /// 扩展信息（JSON字符串）
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 表单编码
        /// </summary>
        [XmlElement("form_code")]
        public string FormCode { get; set; }

        /// <summary>
        /// 页面编码
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }

        /// <summary>
        /// 页面名称
        /// </summary>
        [XmlElement("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("search_fields")]
        [XmlArrayItem("strategy_search_field")]
        public List<StrategySearchField> SearchFields { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("show_fields")]
        [XmlArrayItem("strategy_show_field")]
        public List<StrategyShowField> ShowFields { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sort_fields")]
        [XmlArrayItem("strategy_sort_field")]
        public List<StrategySortField> SortFields { get; set; }

        /// <summary>
        /// 标题字段编码
        /// </summary>
        [XmlElement("title_field")]
        public string TitleField { get; set; }
    }
}
