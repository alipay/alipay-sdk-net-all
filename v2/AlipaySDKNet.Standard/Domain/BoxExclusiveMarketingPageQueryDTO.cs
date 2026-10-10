using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxExclusiveMarketingPageQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BoxExclusiveMarketingPageQueryDTO : AopObject
    {
        /// <summary>
        /// box活动详情
        /// </summary>
        [XmlArray("page_data")]
        [XmlArrayItem("search_box_exclusive_marketing_info_request")]
        public List<SearchBoxExclusiveMarketingInfoRequest> PageData { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_number")]
        public string TotalNumber { get; set; }
    }
}
