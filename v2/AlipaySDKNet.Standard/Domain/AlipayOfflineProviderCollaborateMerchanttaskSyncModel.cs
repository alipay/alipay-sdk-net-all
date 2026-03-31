using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateMerchanttaskSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateMerchanttaskSyncModel : AopObject
    {
        /// <summary>
        /// leads变更原因
        /// </summary>
        [XmlElement("leads_change_reason")]
        public string LeadsChangeReason { get; set; }

        /// <summary>
        /// 商家leads状态变更时间
        /// </summary>
        [XmlElement("leads_status_change_date")]
        public string LeadsStatusChangeDate { get; set; }

        /// <summary>
        /// 商家leads状态
        /// </summary>
        [XmlElement("merchant_leads_status")]
        public string MerchantLeadsStatus { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [XmlElement("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 任务单号leads_id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
