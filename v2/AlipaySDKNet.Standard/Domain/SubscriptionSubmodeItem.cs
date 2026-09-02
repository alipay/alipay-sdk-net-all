using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionSubmodeItem Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionSubmodeItem : AopObject
    {
        /// <summary>
        /// 优惠券 ID；创建或 UPGRADE 场景按需传入，与 pay_amount 互斥，DOWNGRADE 不允许传入
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 订阅生效后由查询或通知接口返回的订阅项目 ID；Submode 创建场景无需传，UPGRADE/DOWNGRADE 场景条件必选
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商户提交的完整价格商品快照；CREATE、UPGRADE、DOWNGRADE 场景条件必选
        /// </summary>
        [XmlElement("price_data")]
        public SubscriptionPriceData PriceData { get; set; }

        /// <summary>
        /// Submode 数量可不传或传 1，后端统一按 1 处理；其他值会返回参数错误
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }
    }
}
