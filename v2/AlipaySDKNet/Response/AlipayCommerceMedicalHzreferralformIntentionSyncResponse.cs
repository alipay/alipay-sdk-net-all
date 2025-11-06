using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHzreferralformIntentionSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHzreferralformIntentionSyncResponse : AopResponse
    {
        /// <summary>
        /// 转诊单状态的同步
        /// </summary>
        [XmlElement("sync_result")]
        public string SyncResult { get; set; }
    }
}
