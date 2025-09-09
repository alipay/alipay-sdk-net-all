using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddOrderRefundModel : AopObject
    {
        /// <summary>
        /// 买家用户唯一标识
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 桌码拓展对象
        /// </summary>
        [XmlElement("code_ext")]
        public CodeExtBean CodeExt { get; set; }

        /// <summary>
        /// 创建订单时支付宝侧返回的订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 退款交易信息留存
        /// </summary>
        [XmlElement("refund_info")]
        public RefundInfoBean RefundInfo { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
