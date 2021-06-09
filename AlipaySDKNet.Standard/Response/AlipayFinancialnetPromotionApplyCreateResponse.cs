using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetPromotionApplyCreateResponse.
    /// </summary>
    public class AlipayFinancialnetPromotionApplyCreateResponse : AopResponse
    {
        /// <summary>
        /// 进件订单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 蚂蚁traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
