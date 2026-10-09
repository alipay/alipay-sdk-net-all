using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNsalesActivityEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNsalesActivityEffectModel : AopObject
    {
        /// <summary>
        /// 活动设备编号
        /// </summary>
        [XmlElement("activity_dvc_sn")]
        public string ActivityDvcSn { get; set; }

        /// <summary>
        /// 卖进订单活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
