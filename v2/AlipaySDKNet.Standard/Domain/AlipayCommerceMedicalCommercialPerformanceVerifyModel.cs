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
        /// 商品订单id，支付宝侧用户对商户某一商品的唯一订单子单id。该订单记录了用户的核销次数与总次数，以及订单状态
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 该参数当业务完结时，需要提供的业务url结果
        /// </summary>
        [XmlElement("biz_url")]
        public string BizUrl { get; set; }

        /// <summary>
        /// 核销业务url类型
        /// </summary>
        [XmlElement("biz_url_type")]
        public string BizUrlType { get; set; }

        /// <summary>
        /// 用户user_id，做了open_id映射
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 用户实际在机构侧核销商品的时间
        /// </summary>
        [XmlElement("consume_time")]
        public string ConsumeTime { get; set; }

        /// <summary>
        /// 用户openid，唯一映射用户userid，用于唯一标识用户
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户在支付宝支付后，医疗行业生成的唯一订单id。在履约通知接口会传递给商户。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，必须保证商户下唯一，用作幂等。当用户在商户侧核销时，商户生成唯一订单号并调用接口时传递
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// out_product_id为商户侧唯一的权商品id标识
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 用于商户核销时，需要携带特殊业务参数场景
        /// </summary>
        [XmlElement("special_biz_info")]
        public string SpecialBizInfo { get; set; }

        /// <summary>
        /// status核销或确认场景使用，枚举值为S\C\R\N，正常核销或确认商品时传S、核销权益次数完结传C、拒绝核销或确认传入N、逆向核销回补使用次数时传递R。 不传默认为S
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// total_count标记用户所拥有商品的总可核销次数，商户在用户核销时传递该字段，可选。
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 已使用次数，usage_count用于记录用户对某一商品的使用次数，每次核销时商户侧进行累加。该字段不影响主逻辑，用于支付宝侧日志监控
        /// </summary>
        [XmlElement("usage_count")]
        public string UsageCount { get; set; }

        /// <summary>
        /// 用于记录实物发货的物流单号、物流公司等信息，并回传给医疗行业侧
        /// </summary>
        [XmlElement("verify_logistics_detail")]
        public VerifyLogisticsDetail VerifyLogisticsDetail { get; set; }

        /// <summary>
        /// 确认场景类型，枚举值： 用户核销，USER_PERFORMANCE。 取消预约，RESERVE_CANCEL。 修改预约，RESERVE_MODIFY。 上传报告，REPORT_UPLOAD。 商家确认发货，DELIVERY。 用户已收到货，DELIVERIED。 商家收到退货或退款确认，REFUND_CONFIRM。 商家待确认预约，WAIT_CONFIRM_RESERVE。 该字段为空值默认动作为用户核销 ：USER_PERFORMANCE。
        /// </summary>
        [XmlElement("verify_type")]
        public string VerifyType { get; set; }
    }
}
