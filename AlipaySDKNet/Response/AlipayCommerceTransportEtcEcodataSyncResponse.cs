using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcEcodataSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcEcodataSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步结果，true/false
        /// </summary>
        [XmlElement("sync_result")]
        public bool SyncResult { get; set; }
    }
}
