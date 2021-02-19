using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreecategoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 节点集合
        /// </summary>
        [XmlArray("categories")]
        [XmlArrayItem("article_category_info")]
        public List<ArticleCategoryInfo> Categories { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页显示大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总行数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
