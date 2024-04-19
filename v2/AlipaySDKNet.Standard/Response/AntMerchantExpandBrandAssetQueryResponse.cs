using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandBrandAssetQueryResponse.
    /// </summary>
    public class AntMerchantExpandBrandAssetQueryResponse : AopResponse
    {
        /// <summary>
        /// 资产ID集合
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("string")]
        public List<string> List { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 单页行数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总行数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
