using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenBrandInfoQueryResponse.
    /// </summary>
    public class AlipayOpenBrandInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("brand_query_open_api_result")]
        public List<BrandQueryOpenApiResult> List { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总数，单位ti
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
