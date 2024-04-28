using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderDeliveryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderDeliveryModifyModel : AopObject
    {
        /// <summary>
        /// 需要修改的活动信息列表
        /// </summary>
        [XmlArray("activity_infos")]
        [XmlArrayItem("activity_info_modify_d_t_o")]
        public List<ActivityInfoModifyDTO> ActivityInfos { get; set; }

        /// <summary>
        /// 酒店预订信息
        /// </summary>
        [XmlElement("booking_info")]
        public BookingInfoDTO BookingInfo { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlElement("contact_info")]
        public ContactInfoDTO ContactInfo { get; set; }

        /// <summary>
        /// 买家open_id；open_id和user_id二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号；order_id和out_order_id二选一
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单请求由商户传入；order_id和out_order_id二选一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 订单的履约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 需要修改的票务信息列表
        /// </summary>
        [XmlArray("ticket_infos")]
        [XmlArrayItem("ticket_info_modify_d_t_o")]
        public List<TicketInfoModifyDTO> TicketInfos { get; set; }

        /// <summary>
        /// 出游信息
        /// </summary>
        [XmlElement("tour_info")]
        public TourInfoDTO TourInfo { get; set; }

        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/mini/05dxgc?pathHash=1a3ecb13">用户授权</a>; 其它场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/open/284/web">网页授权获取用户信息</a>。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
