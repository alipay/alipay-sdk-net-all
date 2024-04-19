using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchAppkeywordBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchAppkeywordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 审核通过关键词明细
        /// </summary>
        [XmlArray("key_word_info")]
        [XmlArrayItem("key_word_info")]
        public List<KeyWordInfo> KeyWordInfo { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
