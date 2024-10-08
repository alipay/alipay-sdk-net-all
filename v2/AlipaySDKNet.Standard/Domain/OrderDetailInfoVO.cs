using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDetailInfoVO : AopObject
    {
        /// <summary>
        /// 拼团信息
        /// </summary>
        [XmlElement("group_buy_info")]
        public GroupBuyInfo GroupBuyInfo { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("order_item_info_v_o")]
        public List<OrderItemInfoVO> ItemInfos { get; set; }

        /// <summary>
        /// 订单标签对象
        /// </summary>
        [XmlElement("order_tag_info")]
        public OrderTagInfo OrderTagInfo { get; set; }

        /// <summary>
        /// 支付信息
        /// </summary>
        [XmlElement("pay_info")]
        public PayInfoVO PayInfo { get; set; }

        /// <summary>
        /// 价格信息
        /// </summary>
        [XmlElement("price_info")]
        public PriceInfoVO PriceInfo { get; set; }

        /// <summary>
        /// 优惠申领信息
        /// </summary>
        [XmlElement("promo_apply_info")]
        public PromoApplyInfoVO PromoApplyInfo { get; set; }

        /// <summary>
        /// 优惠信息，包含分期优惠
        /// </summary>
        [XmlElement("promo_info")]
        public PromoInfoVO PromoInfo { get; set; }
    }
}
