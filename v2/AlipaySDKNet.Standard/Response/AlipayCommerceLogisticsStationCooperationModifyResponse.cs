using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsStationCooperationModifyResponse.
    /// </summary>
    public class AlipayCommerceLogisticsStationCooperationModifyResponse : AopResponse
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 驿站品牌标识
        /// </summary>
        [XmlElement("station_brand_id")]
        public string StationBrandId { get; set; }

        /// <summary>
        /// 驿站平台侧门店id, 对应入参
        /// </summary>
        [XmlElement("station_shop_id")]
        public string StationShopId { get; set; }
    }
}
