using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataHotelServiceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataHotelServiceSyncModel : AopObject
    {
        /// <summary>
        /// 酒店所在小程序的appid
        /// </summary>
        [XmlElement("hotel_app_id")]
        public string HotelAppId { get; set; }

        /// <summary>
        /// 酒店信息
        /// </summary>
        [XmlElement("hotel_info")]
        public HotelInfo HotelInfo { get; set; }

        /// <summary>
        /// [SERVICE_CREATE：服务创建， SERVICE_UPDATE：服务更新， SERVICE_ONLINE: 服务上架， SERVICE_OFFLINE：服务下架 ]  说明：值为SERVICE_CREATE时， 参数servic_id为空；值为其他时， 参数servic_id必填
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 服务商侧酒店id
        /// </summary>
        [XmlElement("outer_hotel_id")]
        public string OuterHotelId { get; set; }

        /// <summary>
        /// 提报服务的描述
        /// </summary>
        [XmlElement("service_description")]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// 支付宝行业酒店服务的标识，第一次服务提报时为null， 更新服务提报时必传，和出参中service_id一致
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 提报服务名称，不要出现特殊字符，建议以 酒店名称+服务类型 组合作为服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务提报类型， 可选值 [HOTEL_RESERVATION : 酒店预订服务, HOTEL_CHECK_IN:酒店入住服务 ]
        /// </summary>
        [XmlElement("service_submit_type")]
        public string ServiceSubmitType { get; set; }

        /// <summary>
        /// 服务提报url
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 服务商的标识， 需要支付宝技术配置。联调前请提前找技术人员配置
        /// </summary>
        [XmlElement("source_system")]
        public string SourceSystem { get; set; }
    }
}
