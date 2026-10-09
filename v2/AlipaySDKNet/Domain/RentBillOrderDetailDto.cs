using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentBillOrderDetailDto Data Structure.
    /// </summary>
    [Serializable]
    public class RentBillOrderDetailDto : AopObject
    {
        /// <summary>
        /// 租赁商实收金额，单位元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 实际扣款时间
        /// </summary>
        [XmlElement("actual_pay_time")]
        public string ActualPayTime { get; set; }

        /// <summary>
        /// 交易组件订单id
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 关联履约单号
        /// </summary>
        [XmlElement("installment_no")]
        public string InstallmentNo { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 还款期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 还款阶段
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 支付明细单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 还款资金类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
