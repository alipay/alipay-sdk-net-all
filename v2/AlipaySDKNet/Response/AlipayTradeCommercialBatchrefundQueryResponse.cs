using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCommercialBatchrefundQueryResponse.
    /// </summary>
    public class AlipayTradeCommercialBatchrefundQueryResponse : AopResponse
    {
        /// <summary>
        /// 实际退款金额，已成功明细的退款金额之和，单位：元
        /// </summary>
        [XmlElement("actual_refund_amount")]
        public string ActualRefundAmount { get; set; }

        /// <summary>
        /// 批量退款执行批次号
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 批次创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("commerce_refund_detail")]
        public List<CommerceRefundDetail> Details { get; set; }

        /// <summary>
        /// 退款失败明细数
        /// </summary>
        [XmlElement("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款批次状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 退款成功明细数
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }

        /// <summary>
        /// 明细总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 批次总退款金额，单位：元
        /// </summary>
        [XmlElement("total_refund_amount")]
        public string TotalRefundAmount { get; set; }
    }
}
