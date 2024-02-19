using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderDeliveryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderDeliveryModifyModel : AopObject
    {
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
        /// CONFIRMED 已确认 用于酒店预订成功 CANCELLED 预约失败 用于酒店预订失败 TO_BE_CHECK_IN 待入住 待入住状态 CHECK_IN 已入住 已入住状态 HAVE_STAY 已续住 已续住状态 TO_CHECK_OUT 待退房 CHECK_OUT 已退房 FINISHED 已完成
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/mini/05dxgc?pathHash=1a3ecb13">用户授权</a>; 其它场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/open/284/web">网页授权获取用户信息</a>。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
