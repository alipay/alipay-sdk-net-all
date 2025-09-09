using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHotelOrderstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHotelOrderstatusSyncModel : AopObject
    {
        /// <summary>
        /// 出行酒店订单id
        /// </summary>
        [XmlElement("alipay_hotel_order_id")]
        public string AlipayHotelOrderId { get; set; }

        /// <summary>
        /// 业务发生事件
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_info")]
        public OrderStatusSyncCancelInfoDTO CancelInfo { get; set; }

        /// <summary>
        /// 推送订单确认状态时填充
        /// </summary>
        [XmlElement("confirmation_info")]
        public OrderStatusSyncConfirmationInfoDTO ConfirmationInfo { get; set; }

        /// <summary>
        /// 买家open_id；
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单请求由商户传入；
        /// </summary>
        [XmlElement("outer_order_id")]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// 枚举值： 已确认:CONFIRMED 确认失败：CONFIRMED_FAIL 待入住:TO_BE_CHECK_IN 已入住:CHECK_IN 已续住:HAVE_STAY 订单取消：CANCELED(和酒店协商一致取消) 已退房:CHECK_OUT 未入住：NO_SHOW 已完成:FINISHED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
