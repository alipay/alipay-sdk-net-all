using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MinRate Data Structure.
    /// </summary>
    [Serializable]
    public class MinRate : AopObject
    {
        /// <summary>
        /// 支付宝酒店原始价，有效正数，单位为元，默认为人名币
        /// </summary>
        [XmlElement("basis")]
        public string Basis { get; set; }

        /// <summary>
        /// 早餐份数，有限整数，无早餐为0
        /// </summary>
        [XmlElement("breakfast_meal_count")]
        public string BreakfastMealCount { get; set; }

        /// <summary>
        /// 取消政策描述
        /// </summary>
        [XmlElement("cancel_policy")]
        public string CancelPolicy { get; set; }

        /// <summary>
        /// 确认时长，单位分钟，立即确认为0
        /// </summary>
        [XmlElement("confirm_minutes")]
        public string ConfirmMinutes { get; set; }

        /// <summary>
        /// 支付宝酒店会员价，有效正数，单位为元，默认为人名币
        /// </summary>
        [XmlElement("member")]
        public string Member { get; set; }

        /// <summary>
        /// 酒店下单方式，在线付 or 到店付
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 支付宝聚合房型id，有效正整数
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }
    }
}
