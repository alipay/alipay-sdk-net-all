using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyVideocallRoomCreateResponse.
    /// </summary>
    public class AlipayCommercePropertyVideocallRoomCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务名称
        /// </summary>
        [XmlElement("biz_name")]
        public string BizName { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 业主ID值
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 房间token
        /// </summary>
        [XmlElement("r_token")]
        public string RToken { get; set; }

        /// <summary>
        /// 视频房间号
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 视频房间签名
        /// </summary>
        [XmlElement("room_sign")]
        public string RoomSign { get; set; }

        /// <summary>
        /// 服务url
        /// </summary>
        [XmlElement("server_url_arr")]
        public string ServerUrlArr { get; set; }

        /// <summary>
        /// 子业务名称
        /// </summary>
        [XmlElement("sub_biz_name")]
        public string SubBizName { get; set; }

        /// <summary>
        /// 用于后续访客记录交互
        /// </summary>
        [XmlElement("visit_biz_id")]
        public string VisitBizId { get; set; }

        /// <summary>
        /// 访客用户Id
        /// </summary>
        [XmlElement("visitor_customer_id")]
        public string VisitorCustomerId { get; set; }
    }
}
