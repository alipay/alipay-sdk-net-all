using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RentDetail : AopObject
    {
        /// <summary>
        /// 租赁商实收金额，单位：元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 实际扣款时间
        /// </summary>
        [XmlElement("actual_pay_time")]
        public string ActualPayTime { get; set; }

        /// <summary>
        /// 实际分账金额，单位：元
        /// </summary>
        [XmlElement("actual_royalty_price")]
        public string ActualRoyaltyPrice { get; set; }

        /// <summary>
        /// 每一期的扣款分期单号
        /// </summary>
        [XmlElement("installment_id")]
        public string InstallmentId { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 代表某一个阶段的第几期的还款计划，要结合stage进行锁定某一期计划
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 分账履约方式
        /// </summary>
        [XmlElement("royalty_deliver_type")]
        public string RoyaltyDeliverType { get; set; }

        /// <summary>
        /// 分账完成时间
        /// </summary>
        [XmlElement("royalty_time")]
        public string RoyaltyTime { get; set; }

        /// <summary>
        /// 分账交易号
        /// </summary>
        [XmlElement("royalty_trade_no")]
        public string RoyaltyTradeNo { get; set; }

        /// <summary>
        /// 还款阶段
        /// </summary>
        [XmlElement("stage")]
        public long Stage { get; set; }

        /// <summary>
        /// 明细单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 资金类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
