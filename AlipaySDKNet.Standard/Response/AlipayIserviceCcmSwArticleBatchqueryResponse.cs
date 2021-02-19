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
    }
}
