using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleProductQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleProductQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品数据
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("recycle_product_d_t_o")]
        public List<RecycleProductDTO> Content { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
