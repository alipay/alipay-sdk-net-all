using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceBookingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceBookingInfo : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("booking_attrs")]
        [XmlArrayItem("life_service_attr")]
        public List<LifeServiceAttr> BookingAttrs { get; set; }

        /// <summary>
        /// 预约创建时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("booking_create_time")]
        public string BookingCreateTime { get; set; }

        /// <summary>
        /// 预约日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("booking_date")]
        public string BookingDate { get; set; }

        /// <summary>
        /// 预约单id
        /// </summary>
        [XmlElement("booking_id")]
        public string BookingId { get; set; }

        /// <summary>
        /// 预约结束时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 预约关联的商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 预约人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 安心生活订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 预约关联的外部商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 预约的外部场地id
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 预约的外部服务项目id
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 预约关联的外部skuid
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 预约的外部手艺人id
        /// </summary>
        [XmlElement("out_technician_id")]
        public string OutTechnicianId { get; set; }

        /// <summary>
        /// 预约人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 预约备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 预约场地id
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 预约的服务项目id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 预约关联的skuid
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 预约开始时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 预约单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 预约的手艺人id
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
