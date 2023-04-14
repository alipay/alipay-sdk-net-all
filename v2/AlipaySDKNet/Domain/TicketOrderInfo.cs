using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TicketOrderInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TicketOrderInfo : AopObject
    {
        /// <summary>
        /// 目的地信息
        /// </summary>
        [XmlElement("arrival")]
        public JourneyLocation Arrival { get; set; }

        /// <summary>
        /// 凭证内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 出发地信息
        /// </summary>
        [XmlElement("departure")]
        public JourneyLocation Departure { get; set; }

        /// <summary>
        /// 凭证有效数
        /// </summary>
        [XmlElement("effective_num")]
        public long EffectiveNum { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 票面价
        /// </summary>
        [XmlElement("face_value")]
        public string FaceValue { get; set; }

        /// <summary>
        /// 功能服务信息
        /// </summary>
        [XmlArray("functional_services")]
        [XmlArrayItem("functional_service")]
        public List<FunctionalService> FunctionalServices { get; set; }

        /// <summary>
        /// 凭证失效原因
        /// </summary>
        [XmlElement("invalid_reason")]
        public string InvalidReason { get; set; }

        /// <summary>
        /// 凭证可使用地点
        /// </summary>
        [XmlArray("locations")]
        [XmlArrayItem("journey_location")]
        public List<JourneyLocation> Locations { get; set; }

        /// <summary>
        /// 商户侧凭证ID或核销码
        /// </summary>
        [XmlElement("merchant_ticket_no")]
        public string MerchantTicketNo { get; set; }

        /// <summary>
        /// 座位信息
        /// </summary>
        [XmlArray("seat_infos")]
        [XmlArrayItem("seat_info")]
        public List<SeatInfo> SeatInfos { get; set; }

        /// <summary>
        /// 凭证服务提供商
        /// </summary>
        [XmlElement("service_provider")]
        public OrderParticipantInfo ServiceProvider { get; set; }

        /// <summary>
        /// 凭证可使用门店列表
        /// </summary>
        [XmlArray("shops")]
        [XmlArrayItem("order_shop_info")]
        public List<OrderShopInfo> Shops { get; set; }

        /// <summary>
        /// 凭证开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 凭证状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 凭证创建时间
        /// </summary>
        [XmlElement("ticket_create_time")]
        public string TicketCreateTime { get; set; }

        /// <summary>
        /// 凭证修改时间，精确到毫秒
        /// </summary>
        [XmlElement("ticket_modify_time")]
        public string TicketModifyTime { get; set; }

        /// <summary>
        /// 凭证购买数
        /// </summary>
        [XmlElement("ticket_num")]
        public long TicketNum { get; set; }

        /// <summary>
        /// 凭证使用者信息
        /// </summary>
        [XmlArray("ticket_users")]
        [XmlArrayItem("user_infomation")]
        public List<UserInfomation> TicketUsers { get; set; }

        /// <summary>
        /// 凭证标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 交通工具信息
        /// </summary>
        [XmlElement("vehicle_info")]
        public OrderVehicleInfo VehicleInfo { get; set; }
    }
}
