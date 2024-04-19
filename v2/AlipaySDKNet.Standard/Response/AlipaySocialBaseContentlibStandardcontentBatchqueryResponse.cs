using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardcontentBatchqueryResponse.
    /// </summary>
    public class AlipaySocialBaseContentlibStandardcontentBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 内容详情列表
        /// </summary>
        [XmlArray("content_details")]
        [XmlArrayItem("source_content_info")]
        public List<SourceContentInfo> ContentDetails { get; set; }

        /// <summary>
        /// 内容ID列表
        /// </summary>
        [XmlArray("content_ids")]
        [XmlArrayItem("string")]
        public List<string> ContentIds { get; set; }

        /// <summary>
        /// 当前分页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
