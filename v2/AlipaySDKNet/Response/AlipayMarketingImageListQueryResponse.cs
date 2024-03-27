using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingImageListQueryResponse.
    /// </summary>
    public class AlipayMarketingImageListQueryResponse : AopResponse
    {
        /// <summary>
        /// 图片列表。
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("image_v_o")]
        public List<ImageVO> Data { get; set; }

        /// <summary>
        /// 当前页码。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页条数。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量。
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 总页数。
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
