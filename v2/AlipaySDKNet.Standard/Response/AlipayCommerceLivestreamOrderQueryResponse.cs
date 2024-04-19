using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLivestreamOrderQueryResponse.
    /// </summary>
    public class AlipayCommerceLivestreamOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单列表
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("livestream_order")]
        public List<LivestreamOrder> Contents { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 订单总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
