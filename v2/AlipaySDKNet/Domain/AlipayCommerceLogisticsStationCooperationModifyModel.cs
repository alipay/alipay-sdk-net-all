using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsStationCooperationModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsStationCooperationModifyModel : AopObject
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// open_id是用户（UserId）在应用（AppId）下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 驿站品牌标识
        /// </summary>
        [XmlElement("station_brand_id")]
        public string StationBrandId { get; set; }

        /// <summary>
        /// 驿站平台侧门店id
        /// </summary>
        [XmlElement("station_shop_id")]
        public string StationShopId { get; set; }

        /// <summary>
        /// 驿站平台侧用户id
        /// </summary>
        [XmlElement("station_user_id")]
        public string StationUserId { get; set; }

        /// <summary>
        /// 用户支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
