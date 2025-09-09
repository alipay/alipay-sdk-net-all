using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcOrderSyncModel : AopObject
    {
        /// <summary>
        /// 商家侧订单实际金额，金额单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商家订单实际的买家uid
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家用户的支付宝openid
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 商家侧订单优惠金额，金额单位为元
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 订单扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("ec_order_ext_info")]
        public List<EcOrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 订单商品信息列表
        /// </summary>
        [XmlArray("goods_info")]
        [XmlArrayItem("ec_order_goods_info")]
        public List<EcOrderGoodsInfo> GoodsInfo { get; set; }

        /// <summary>
        /// 商家侧订单实际创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单修改时间较晚的信息会被最终存储
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 商家侧订单实际支付时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 商家侧自定义订单号，同一笔订单必须保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商家侧订单实际支付金额，金额单位为元
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单发生的平台，默认为Alipay
        /// </summary>
        [XmlElement("source_app")]
        public string SourceApp { get; set; }

        /// <summary>
        /// 商家侧订单使用支付宝支付时，对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
