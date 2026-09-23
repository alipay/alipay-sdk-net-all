using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EbppRefundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EbppRefundInfo : AopObject
    {
        /// <summary>
        /// 描述业务的归属类
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 订单归属的出账机构
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 业务归属的销账机构
        /// </summary>
        [XmlElement("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 收到退款请求的时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 退款时间，yyyy-MM-dd hh:mm:ss格式，未退款的订单无退款时间。
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_ext_id")]
        public string OutExtId { get; set; }

        /// <summary>
        /// 退款金额，单位是元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款单号，已经退款的订单有此编号，其他状态可能暂未生成。
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退款支付单号
        /// </summary>
        [XmlElement("refund_payment_id")]
        public string RefundPaymentId { get; set; }

        /// <summary>
        /// 描述退款的原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款状态代码
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款类型
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [XmlElement("retry_times")]
        public string RetryTimes { get; set; }
    }
}
