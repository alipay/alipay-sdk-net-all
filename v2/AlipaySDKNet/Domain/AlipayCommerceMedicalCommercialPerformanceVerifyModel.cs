using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialPerformanceVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialPerformanceVerifyModel : AopObject
    {
        /// <summary>
        /// 权益订单id，支付宝侧用户对商户某一权益的唯一订单子单id。该订单记录了用户的核销次数与总次数，以及订单状态
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 用户user_id，做了open_id映射
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 用户实际在机构侧核销权益的时间
        /// </summary>
        [XmlElement("consume_time")]
        public string ConsumeTime { get; set; }

        /// <summary>
        /// 用户openid，唯一映射用户userid，用于唯一标识用户
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户在支付宝支付后，医疗行业生成的唯一订单id。在履约通知接口会传递给商户，并且在会员卡权益新增时，商户需要识别用户并绑定当前生效订单id与商户侧用户可使用的权益
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，必须保证商户下唯一，用作幂等。当用户在商户侧核销时，商户生成唯一订单号并调用接口时传递
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// out_product_id为商户侧唯一的权益id标识
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// status核销场景使用，枚举值为S\A\C\R，用户正常核销权益时传S，表示可使用状态。核销权益次数完结传C，用户核销已买会员卡新增的权益时传递A状态，用户逆向核销回补使用次数时传递R状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// total_count标记用户所拥有权益的总可核销次数，商户在用户核销时传递该字段，可选。
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// usage_count用于记录用户对某一权益的使用次数，每次核销时商户侧进行累加。该字段不影响主逻辑，用于支付宝侧日志监控
        /// </summary>
        [XmlElement("usage_count")]
        public string UsageCount { get; set; }
    }
}
