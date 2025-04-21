using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMisetorderOrdernoBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMisetorderOrdernoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("number")]
        public List<long> Data { get; set; }

        /// <summary>
        /// 是：有下一页，否：无下一页数据
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页显示多少条，默认为20,最大100,取值范围：[20,100]
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
