using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionChannelBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionChannelBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 渠道信息
        /// </summary>
        [XmlElement("data")]
        public KbAdvertChannelResponse Data { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页页数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
