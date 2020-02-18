using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodPaymentQueryResponse.
    /// </summary>
    public class MybankCreditSceneprodPaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 交易完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 网商内部代收付申请单编号
        /// </summary>
        [XmlElement("in_apply_no")]
        public string InApplyNo { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 代收付申请单状态： SUC 成功，PRO 执行中 ，FAIL 失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
