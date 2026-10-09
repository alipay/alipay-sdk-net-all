using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityIsvpayrecordModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityIsvpayrecordModifyModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 创单时平台生成并传给服务商的统一单号，回写定位、校验、更新均以其为准
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 房屋外部户号
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付单号, 创单SPI接口返回
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
