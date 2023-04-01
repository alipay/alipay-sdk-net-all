using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderDeliverySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderDeliverySendModel : AopObject
    {
        /// <summary>
        /// 快递信息，delivery_type=1时必填，订单中心限制5条
        /// </summary>
        [XmlArray("delivery_list")]
        [XmlArrayItem("delivery_info_d_t_o")]
        public List<DeliveryInfoDTO> DeliveryList { get; set; }

        /// <summary>
        /// 发货完成标志位, 0: 未发完, 1:已发完
        /// </summary>
        [XmlElement("finish_all_delivery")]
        public long FinishAllDelivery { get; set; }

        /// <summary>
        /// 商户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 格式为yyyy-MM-dd HH:mm:ss。 注：finish_all_delivery = 1的时候 必传
        /// </summary>
        [XmlElement("ship_done_time")]
        public string ShipDoneTime { get; set; }

        /// <summary>
        /// 商户UID（与openId二选一）
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
