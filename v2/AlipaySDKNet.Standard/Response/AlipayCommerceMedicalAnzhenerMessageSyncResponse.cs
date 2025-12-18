using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAnzhenerMessageSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalAnzhenerMessageSyncResponse : AopResponse
    {
        /// <summary>
        /// true:成功 false:失败
        /// </summary>
        [XmlElement("send_sync_message")]
        public bool SendSyncMessage { get; set; }
    }
}
