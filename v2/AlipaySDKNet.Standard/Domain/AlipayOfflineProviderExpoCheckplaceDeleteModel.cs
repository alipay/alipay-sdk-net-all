using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoCheckplaceDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoCheckplaceDeleteModel : AopObject
    {
        /// <summary>
        /// 活动code
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 打卡点id
        /// </summary>
        [XmlElement("place_id")]
        public string PlaceId { get; set; }
    }
}
