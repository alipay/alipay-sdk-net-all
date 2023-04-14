using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchSubservicekeywordBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchSubservicekeywordBatchqueryResponse : AopResponse
    {
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
        /// 关键词明细
        /// </summary>
        [XmlArray("subservice_keyword_info")]
        [XmlArrayItem("sub_service_key_word_info")]
        public List<SubServiceKeyWordInfo> SubserviceKeywordInfo { get; set; }

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
