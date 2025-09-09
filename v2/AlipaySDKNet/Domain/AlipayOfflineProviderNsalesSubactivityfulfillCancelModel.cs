using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNsalesSubactivityfulfillCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNsalesSubactivityfulfillCancelModel : AopObject
    {
        /// <summary>
        /// 卖进订单子活动id
        /// </summary>
        [XmlElement("sub_activity_id")]
        public string SubActivityId { get; set; }
    }
}
