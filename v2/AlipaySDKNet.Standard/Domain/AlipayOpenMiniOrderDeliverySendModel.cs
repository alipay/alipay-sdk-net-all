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
        /// 订单物流信息，电商购物订单必填且物流数量限制5条；虚拟商品订单非必填
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
        /// 买家open_id；open_id和user_id二选一
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单请求由商户传入
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 完成发货时间，格式为yyyy-MM-dd  HH:mm:ss；注：finish_all_delivery = 1的时候 必传
        /// </summary>
        [XmlElement("ship_done_time")]
        public string ShipDoneTime { get; set; }

        /// <summary>
        /// 买家支付宝用户ID；open_id和user_id二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
