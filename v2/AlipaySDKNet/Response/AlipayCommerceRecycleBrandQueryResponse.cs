using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleBrandQueryResponse.
    /// </summary>
    public class AlipayCommerceRecycleBrandQueryResponse : AopResponse
    {
        /// <summary>
        /// 品牌数据
        /// </summary>
        [XmlArray("content")]
        [XmlArrayItem("recycle_brand")]
        public List<RecycleBrand> Content { get; set; }

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
