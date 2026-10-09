using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSmddTradeSuccessNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSmddTradeSuccessNotifyModel : AopObject
    {
        /// <summary>
        /// 买家唯一标识
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 桌码拓展对象
        /// </summary>
        [XmlElement("code_ext")]
        public CodeExtBean CodeExt { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付成功信息
        /// </summary>
        [XmlElement("pay_info")]
        public PayInfoBean PayInfo { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
