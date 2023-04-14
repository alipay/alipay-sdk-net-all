using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcomRefundDisputeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EcomRefundDisputeDTO : AopObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家退货物流公司编码
        /// </summary>
        [XmlElement("buyer_logistic_company_code")]
        public string BuyerLogisticCompanyCode { get; set; }

        /// <summary>
        /// 买家退货物流公司名称
        /// </summary>
        [XmlElement("buyer_logistic_company_name")]
        public string BuyerLogisticCompanyName { get; set; }

        /// <summary>
        /// 买家退货物流单号
        /// </summary>
        [XmlElement("buyer_logistic_no")]
        public string BuyerLogisticNo { get; set; }

        /// <summary>
        /// 案件发生时间
        /// </summary>
        [XmlElement("case_time")]
        public string CaseTime { get; set; }

        /// <summary>
        /// 纠纷结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 纠纷时买家对货物的诉求         ANY(any),          REFUND(仅退款),         REFUND_WITH_GOODS(退货退款),         EXCHANGE_OR_MAINTAIN(维修换货),         REPOST(补寄)
        /// </summary>
        [XmlElement("goods_needs")]
        public string GoodsNeeds { get; set; }

        /// <summary>
        /// 货物状态 UNSHIPPED(未发货),     SHIPPED(已发货),     NOT_RECEIVE_GOORDS(未收到货),     RECEIVE_GOODS(已收到货),     RETURN_GOODS(已寄回),     CONFIRM_GOODS(卖家确认收货)
        /// </summary>
        [XmlElement("goods_status")]
        public string GoodsStatus { get; set; }

        /// <summary>
        /// 交易订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 退款原因类型
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 退款原因描述
        /// </summary>
        [XmlElement("reason_text")]
        public string ReasonText { get; set; }

        /// <summary>
        /// 买家退款说明
        /// </summary>
        [XmlElement("refund_desc")]
        public string RefundDesc { get; set; }

        /// <summary>
        /// 退款纠纷单id
        /// </summary>
        [XmlElement("refund_dispute_id")]
        public string RefundDisputeId { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_fee")]
        public long RefundFee { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款要求类型 对应dispute_type
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 纠纷发起时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
