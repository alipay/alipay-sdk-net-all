using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMallItemSyncResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMallItemSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步任务创建状态
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
