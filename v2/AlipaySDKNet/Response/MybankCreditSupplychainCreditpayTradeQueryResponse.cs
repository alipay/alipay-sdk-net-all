using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayTradeQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 买方信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 1688买家ID
        /// </summary>
        [XmlElement("buyer_scene_id")]
        public string BuyerSceneId { get; set; }

        /// <summary>
        /// 确认收货金额
        /// </summary>
        [XmlElement("confirm_amt")]
        public string ConfirmAmt { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [XmlElement("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        [XmlElement("refund_amt")]
        public string RefundAmt { get; set; }

        /// <summary>
        /// 卖方信息
        /// </summary>
        [XmlElement("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// 1688卖家ID
        /// </summary>
        [XmlElement("seller_scene_id")]
        public string SellerSceneId { get; set; }

        /// <summary>
        /// 源订单ID，1688订单ID
        /// </summary>
        [XmlElement("source_order_no")]
        public string SourceOrderNo { get; set; }

        /// <summary>
        /// 订单状态：VALID/INVALID/INIT/CANCEL
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 网商日志追踪ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 订单金额，单位：分
        /// </summary>
        [XmlElement("trade_amt")]
        public string TradeAmt { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
