using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenLtsnapshotBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeopenLtsnapshotBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("lt_snapshot_d_t_o")]
        public List<LtSnapshotDTO> Data { get; set; }
    }
}
