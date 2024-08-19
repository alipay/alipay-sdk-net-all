using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwArticleBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwArticleBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 文章信息
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("article_info")]
        public List<ArticleInfo> Articles { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
