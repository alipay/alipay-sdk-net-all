using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationUserTaskSyncResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationUserTaskSyncResponse : AopResponse
    {
        /// <summary>
        /// true表示同步成功
        /// </summary>
        [XmlElement("sync_success")]
        public bool SyncSuccess { get; set; }
    }
}
