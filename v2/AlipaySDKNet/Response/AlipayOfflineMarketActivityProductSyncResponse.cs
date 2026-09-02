using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketActivityProductSyncResponse.
    /// </summary>
    public class AlipayOfflineMarketActivityProductSyncResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("failed_activity_batch_ids")]
        [XmlArrayItem("string")]
        public List<string> FailedActivityBatchIds { get; set; }
    }
}
