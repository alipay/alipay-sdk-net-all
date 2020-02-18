using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotedetailBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotedetailBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 业务数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("promote_detail_model")]
        public List<PromoteDetailModel> Data { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页大小
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
