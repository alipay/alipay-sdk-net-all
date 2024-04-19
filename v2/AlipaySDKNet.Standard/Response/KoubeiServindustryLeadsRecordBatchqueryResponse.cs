using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryLeadsRecordBatchqueryResponse.
    /// </summary>
    public class KoubeiServindustryLeadsRecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 客资详情列表
        /// </summary>
        [XmlArray("leads_order_info_list")]
        [XmlArrayItem("leads_order_info")]
        public List<LeadsOrderInfo> LeadsOrderInfoList { get; set; }

        /// <summary>
        /// 客资总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
