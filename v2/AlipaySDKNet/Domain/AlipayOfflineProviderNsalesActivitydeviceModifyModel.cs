using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNsalesActivitydeviceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNsalesActivitydeviceModifyModel : AopObject
    {
        /// <summary>
        /// 卖进订单活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动原设备编号
        /// </summary>
        [XmlElement("source_sn")]
        public string SourceSn { get; set; }

        /// <summary>
        /// 活动目标替换设备编号
        /// </summary>
        [XmlElement("target_sn")]
        public string TargetSn { get; set; }
    }
}
