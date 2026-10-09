using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceTradevoiceSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceTradevoiceSendModel : AopObject
    {
        /// <summary>
        /// 播报的金额，单位元 必须大于0
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 语料资源的消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 支付宝外部订单号，即商家订单号。当交易类型为ALIPAY_TRADE时，和支付宝订单号trade_id两者选其中之一传，为OTHER时out_order_no不用传，trade_id必传
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 配合promo_msg_id模板使用的营销语料的金额，单位元
        /// </summary>
        [XmlElement("promo_coupon_money")]
        public string PromoCouponMoney { get; set; }

        /// <summary>
        /// 用于与promo_msg_id配合来使用的动参优惠券数量，单位笔
        /// </summary>
        [XmlElement("promo_coupon_num")]
        public string PromoCouponNum { get; set; }

        /// <summary>
        /// 主要作用是在到账播报后播放营销预料，需要服务商提前联系业务运营申请并取得 promo_msg_id
        /// </summary>
        [XmlElement("promo_msg_id")]
        public string PromoMsgId { get; set; }

        /// <summary>
        /// 间连商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 交易订单id,生产环境交易类型为OTHER必传。 为ALIPAY_TARDE时和out_order_no两者选一传 工厂验收设备的时候可不传，通过白名单管控。
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 交易类型 可选值: ALIPAY_TRADE 支付宝交易  OTHER 其他交易途径
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
