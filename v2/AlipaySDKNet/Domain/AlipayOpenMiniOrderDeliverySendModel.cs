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
        /// 物流信息列表，由商品类型决定，目前电商购物场景最多传5个，虚拟商品不需要传入
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
        /// 完成发货时间，格式为yyyy-MM-dd  HH:mm:ss
        /// </summary>
        [XmlElement("ship_done_time")]
        public string ShipDoneTime { get; set; }

        /// <summary>
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/mini/05dxgc?pathHash=1a3ecb13">用户授权</a>; 其它场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/open/284/web">网页授权获取用户信息</a>。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
