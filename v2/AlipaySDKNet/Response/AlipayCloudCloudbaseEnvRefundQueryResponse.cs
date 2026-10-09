using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvRefundQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvRefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 退款金额（单位：元）
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款方式
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 总金额（单位：元）
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 已使用金额（单位：元）
        /// </summary>
        [XmlElement("use_amount")]
        public string UseAmount { get; set; }

        /// <summary>
        /// 使用时长（精确到秒级）
        /// </summary>
        [XmlElement("use_time")]
        public string UseTime { get; set; }
    }
}
