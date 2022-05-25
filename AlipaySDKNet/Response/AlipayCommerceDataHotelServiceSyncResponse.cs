using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceDataHotelServiceSyncResponse.
    /// </summary>
    public class AlipayCommerceDataHotelServiceSyncResponse : AopResponse
    {
        /// <summary>
        /// 服务提报失败原因
        /// </summary>
        [XmlElement("audit_msg")]
        public string AuditMsg { get; set; }

        /// <summary>
        /// 审核状态 [AUDIT_AGREE ：审核通过，AUDIT_REJECT：审核不通过， AUDITING：审核中]
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 酒店所在小程序的appid
        /// </summary>
        [XmlElement("hotel_app_id")]
        public string HotelAppId { get; set; }

        /// <summary>
        /// 支付宝侧维护的酒店id
        /// </summary>
        [XmlElement("hotel_id")]
        public string HotelId { get; set; }

        /// <summary>
        /// 服务商侧酒店id
        /// </summary>
        [XmlElement("outer_hotel_id")]
        public string OuterHotelId { get; set; }

        /// <summary>
        /// 支付宝行业侧服务的标识
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// [ONLINE : 服务上架， OFFLINE ：服务下架]
        /// </summary>
        [XmlElement("service_status")]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 服务连接，对应入参的service_url
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
