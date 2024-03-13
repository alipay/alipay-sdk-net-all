using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderRefundModel : AopObject
    {
        /// <summary>
        /// 分期单号,指定分期退款的时候需要传入
        /// </summary>
        [XmlElement("installment_order_id")]
        public string InstallmentOrderId { get; set; }

        /// <summary>
        /// 部分商品退款信息
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("mini_refund_goods_info_d_t_o")]
        public List<MiniRefundGoodsInfoDTO> ItemInfos { get; set; }

        /// <summary>
        /// 买家open_id；open_id和user_id二选一
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
        /// 外部退款流水号,标识一次退款请求，需要保证在订单号下唯一。 注：针对同一次退款请求，如果调用接口失败或异常了，重试时需要保证退款流水号不能变更，防止该笔交易重复退款。支付宝会保证同样的退款流水号多次请求只会退一次。
        /// </summary>
        [XmlElement("out_refund_id")]
        public string OutRefundId { get; set; }

        /// <summary>
        /// 退款金额,单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund")]
        public string Refund { get; set; }

        /// <summary>
        /// 退款原因说明。 商家自定义，将会在商户和用户的pc退款账单详情中展示
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 买家支付宝用户ID；open_id和user_id二选一
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
