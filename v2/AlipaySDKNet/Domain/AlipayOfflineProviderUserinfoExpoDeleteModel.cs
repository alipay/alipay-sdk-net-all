using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderUserinfoExpoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderUserinfoExpoDeleteModel : AopObject
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 活动最小单元ID
        /// </summary>
        [XmlElement("time_uuid")]
        public string TimeUuid { get; set; }
    }
}
