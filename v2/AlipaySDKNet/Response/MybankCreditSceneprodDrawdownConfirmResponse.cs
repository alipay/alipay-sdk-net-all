using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodDrawdownConfirmResponse.
    /// </summary>
    public class MybankCreditSceneprodDrawdownConfirmResponse : AopResponse
    {
        /// <summary>
        /// 网商针对一次客户主动申请生成的申请单据编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 处理时错误原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 资方生成的申请单号
        /// </summary>
        [XmlElement("fin_order_no")]
        public string FinOrderNo { get; set; }

        /// <summary>
        /// 受理结果,成功：Y, 失败：N
        /// </summary>
        [XmlElement("process_result")]
        public string ProcessResult { get; set; }

        /// <summary>
        /// 标识一次业务交互, 网商的ipRoleId+"_"YYYYMMDD+35位流水号, 最后2，3位要求是数字。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
