using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoItemConsultDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoItemConsultDetailInfo : AopObject
    {
        /// <summary>
        /// 是否可购买
        /// </summary>
        [XmlElement("buy_restrict")]
        public bool BuyRestrict { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化.
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商家侧商品ID，是商户侧商品的唯一标识，由商家自定义，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部skuid
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 优惠金额，单位 元
        /// </summary>
        [XmlElement("promo_amount")]
        public string PromoAmount { get; set; }

        /// <summary>
        /// 商品优惠子类型包括： MEMBER_POINTS：会员积分价
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// MEMBER_POINT_INSUFFICIENT：用户会员积分余额不足；NOT_ALIPAY_MEMBER：非会员用户；RPC_SERVICE_ERROR：会员调用失败、超时、会员返回接口异常；MEMBER_ASSERT_UNAVAILABLE：会员优惠不可用-兜底异常（会员风控等）
        /// </summary>
        [XmlElement("restrict_code")]
        public string RestrictCode { get; set; }

        /// <summary>
        /// 不可购买原因
        /// </summary>
        [XmlElement("restrict_reason")]
        public string RestrictReason { get; set; }

        /// <summary>
        /// 商品优惠类型包括： ANT_MEMBER : 会员积分 CONSUME_GOLD：消费金
        /// </summary>
        [XmlElement("sale_promo_type")]
        public string SalePromoType { get; set; }

        /// <summary>
        /// 单商品单件需要消耗的积分数
        /// </summary>
        [XmlElement("single_consume")]
        public string SingleConsume { get; set; }

        /// <summary>
        /// 平台skuid
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }
    }
}
