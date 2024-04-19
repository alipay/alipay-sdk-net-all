using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderDeliveryReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderDeliveryReceiveModel : AopObject
    {
        /// <summary>
        /// 确认收货的物流单列表，当有多个物流单时，可以指定物流单确认收货，不传入时，默认进行全部确认收货。
        /// </summary>
        [XmlArray("delivery_receive_list")]
        [XmlArrayItem("delivery_receive_d_t_o")]
        public List<DeliveryReceiveDTO> DeliveryReceiveList { get; set; }

        /// <summary>
        /// 买家open_id
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
        /// 买家支付宝用户id，小程序场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/mini/05dxgc?pathHash=1a3ecb13">用户授权</a>; 其它场景下获取用户ID请参考：<a href="https://opendocs.alipay.com/open/284/web">网页授权获取用户信息</a>。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
