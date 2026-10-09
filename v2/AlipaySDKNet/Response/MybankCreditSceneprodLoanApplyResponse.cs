using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodLoanApplyResponse.
    /// </summary>
    public class MybankCreditSceneprodLoanApplyResponse : AopResponse
    {
        /// <summary>
        /// 网商银行内部申请单号
        /// </summary>
        [XmlElement("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 是否需要升级支付宝账户，如果为true，则需要引导客户进行支付宝账户升级，否则会影响客户的审批流程
        /// </summary>
        [XmlElement("need_auth")]
        public string NeedAuth { get; set; }

        /// <summary>
        /// 外部机构订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

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
