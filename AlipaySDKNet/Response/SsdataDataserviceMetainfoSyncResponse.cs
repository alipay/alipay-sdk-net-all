using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceMetainfoSyncResponse.
    /// </summary>
    public class SsdataDataserviceMetainfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 是否同步成功
        /// </summary>
        [XmlElement("is_sync_success")]
        public bool IsSyncSuccess { get; set; }

        /// <summary>
        /// 返回同步成功或者失败的信息
        /// </summary>
        [XmlElement("sync_result")]
        public string SyncResult { get; set; }
    }
}
