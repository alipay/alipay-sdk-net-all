using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PayOrderDTO : AopObject
    {
        /// <summary>
        /// 买家实际支付金额
        /// </summary>
        [XmlElement("actual_total_fee")]
        public long ActualTotalFee { get; set; }

        /// <summary>
        /// 收款账户
        /// </summary>
        [XmlElement("in_account_no")]
        public string InAccountNo { get; set; }

        /// <summary>
        /// 收款账户类型:OTHER 第三方平台
        /// </summary>
        [XmlElement("in_account_type")]
        public string InAccountType { get; set; }

        /// <summary>
        /// 付款账户
        /// </summary>
        [XmlElement("out_account_no")]
        public string OutAccountNo { get; set; }

        /// <summary>
        /// 账户类型：OTHER 其它第三方平台
        /// </summary>
        [XmlElement("out_account_type")]
        public string OutAccountType { get; set; }

        /// <summary>
        /// 支付流水号
        /// </summary>
        [XmlElement("pay_flow_id")]
        public string PayFlowId { get; set; }

        /// <summary>
        /// 支付订单id
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        [XmlElement("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 订单总金额，单价×数量
        /// </summary>
        [XmlElement("total_fee")]
        public long TotalFee { get; set; }
    }
}
