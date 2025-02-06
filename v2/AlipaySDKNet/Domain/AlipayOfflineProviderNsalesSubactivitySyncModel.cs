using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNsalesSubactivitySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNsalesSubactivitySyncModel : AopObject
    {
        /// <summary>
        /// 卖进订单子活动同步状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("sub_activity_id")]
        public string SubActivityId { get; set; }

        /// <summary>
        /// 用于标记本次推进的原因，多用于非正常推进时标记具体原因。
        /// </summary>
        [XmlElement("sync_memo")]
        public string SyncMemo { get; set; }
    }
}
