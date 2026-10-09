using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StationShop Data Structure.
    /// </summary>
    [Serializable]
    public class StationShop : AopObject
    {
        /// <summary>
        /// 驿站平台侧门店id
        /// </summary>
        [XmlElement("station_shop_id")]
        public string StationShopId { get; set; }

        /// <summary>
        /// 驿站平台侧门店名称
        /// </summary>
        [XmlElement("station_shop_name")]
        public string StationShopName { get; set; }
    }
}
