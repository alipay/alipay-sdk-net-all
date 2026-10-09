using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailvoiceConfigSyncResponse.
    /// </summary>
    public class AlipayCommerceRetailvoiceConfigSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步任务id
        /// </summary>
        [XmlElement("sync_task_id")]
        public string SyncTaskId { get; set; }
    }
}
