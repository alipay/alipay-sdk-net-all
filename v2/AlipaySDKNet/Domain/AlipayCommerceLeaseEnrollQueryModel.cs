using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLeaseEnrollQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLeaseEnrollQueryModel : AopObject
    {
        /// <summary>
        /// 关联品牌方标签
        /// </summary>
        [XmlArray("brand_tags")]
        [XmlArrayItem("string")]
        public List<string> BrandTags { get; set; }

        /// <summary>
        /// 计划名称，支持搜索
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分页页数，默认1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页每页数量，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
