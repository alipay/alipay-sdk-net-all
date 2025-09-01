using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentBillRoyaltyDetailDto Data Structure.
    /// </summary>
    [Serializable]
    public class RentBillRoyaltyDetailDto : AopObject
    {
        /// <summary>
        /// 实际分账金额，单位元
        /// </summary>
        [XmlElement("actual_royalty_amount")]
        public string ActualRoyaltyAmount { get; set; }

        /// <summary>
        /// 交易组件订单id
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 分账资方pid
        /// </summary>
        [XmlElement("invest_id")]
        public string InvestId { get; set; }

        /// <summary>
        /// 本次分账明细对应的租赁单期数，多条用英文逗号分隔
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 分账计划列表
        /// </summary>
        [XmlArray("rent_royalty_list")]
        [XmlArrayItem("rent_bill_royalty_dto")]
        public List<RentBillRoyaltyDto> RentRoyaltyList { get; set; }

        /// <summary>
        /// 分账履约方式
        /// </summary>
        [XmlElement("royalty_deliver_type")]
        public string RoyaltyDeliverType { get; set; }

        /// <summary>
        /// 本次分账明细关联的分账计划id，多条用英文逗号分隔
        /// </summary>
        [XmlElement("royalty_id")]
        public string RoyaltyId { get; set; }

        /// <summary>
        /// 分账履约单号
        /// </summary>
        [XmlElement("royalty_installment_no")]
        public string RoyaltyInstallmentNo { get; set; }

        /// <summary>
        /// 分账支付方式
        /// </summary>
        [XmlElement("royalty_payment_method")]
        public string RoyaltyPaymentMethod { get; set; }

        /// <summary>
        /// 分账支付方式备注，履约单号+"-到卡"或者+"到户"
        /// </summary>
        [XmlElement("royalty_payment_method_note")]
        public string RoyaltyPaymentMethodNote { get; set; }

        /// <summary>
        /// 分账完成时间
        /// </summary>
        [XmlElement("royalty_time")]
        public string RoyaltyTime { get; set; }

        /// <summary>
        /// 分账触发方式
        /// </summary>
        [XmlElement("royalty_trigger_type")]
        public string RoyaltyTriggerType { get; set; }

        /// <summary>
        /// 分账商家pid
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 特殊分账标
        /// </summary>
        [XmlElement("special_royalty_type")]
        public string SpecialRoyaltyType { get; set; }

        /// <summary>
        /// 本次分账明细对应的租赁单阶段，多条用英文逗号分隔
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
