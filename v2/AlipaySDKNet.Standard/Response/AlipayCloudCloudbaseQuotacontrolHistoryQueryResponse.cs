using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseQuotacontrolHistoryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseQuotacontrolHistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 额度防控规则历史列表
        /// </summary>
        [XmlArray("histories")]
        [XmlArrayItem("quota_control_history_record")]
        public List<QuotaControlHistoryRecord> Histories { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
