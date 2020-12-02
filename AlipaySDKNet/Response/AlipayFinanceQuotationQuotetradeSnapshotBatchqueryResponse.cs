using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeSnapshotBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeSnapshotBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 快照对象
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("snapshot_d_t_o")]
        public List<SnapshotDTO> Data { get; set; }
    }
}
