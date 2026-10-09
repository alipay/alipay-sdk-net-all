using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleSimpleInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleSimpleInfoVO : AopObject
    {
        /// <summary>
        /// 售后单的创建方式
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 平台售后单号
        /// </summary>
        [XmlElement("aftersale_id")]
        public string AftersaleId { get; set; }

        /// <summary>
        /// 售后单发起原因
        /// </summary>
        [XmlElement("aftersale_reason")]
        public string AftersaleReason { get; set; }

        /// <summary>
        /// 申请退款金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("apply_refund_amount")]
        public string ApplyRefundAmount { get; set; }

        /// <summary>
        /// 售后单创建时间，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部售后单号
        /// </summary>
        [XmlElement("out_aftersale_id")]
        public string OutAftersaleId { get; set; }

        /// <summary>
        /// 售后状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 售后单类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
