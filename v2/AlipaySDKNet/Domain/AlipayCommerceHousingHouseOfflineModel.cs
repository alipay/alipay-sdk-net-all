using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingHouseOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingHouseOfflineModel : AopObject
    {
        /// <summary>
        /// 房源来源
        /// </summary>
        [XmlElement("house_source")]
        public string HouseSource { get; set; }

        /// <summary>
        /// 房源id
        /// </summary>
        [XmlElement("housing_id")]
        public string HousingId { get; set; }

        /// <summary>
        /// 下架原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
