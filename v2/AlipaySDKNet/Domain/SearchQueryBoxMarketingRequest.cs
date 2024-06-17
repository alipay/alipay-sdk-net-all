using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchQueryBoxMarketingRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchQueryBoxMarketingRequest : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 是否模糊匹配
        /// </summary>
        [XmlElement("fuzzy_matching")]
        public bool FuzzyMatching { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 查询上一个版本
        /// </summary>
        [XmlElement("query_last_version")]
        public bool QueryLastVersion { get; set; }

        /// <summary>
        /// 查询关联服务的信息
        /// </summary>
        [XmlElement("query_serv_info")]
        public bool QueryServInfo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }
    }
}
