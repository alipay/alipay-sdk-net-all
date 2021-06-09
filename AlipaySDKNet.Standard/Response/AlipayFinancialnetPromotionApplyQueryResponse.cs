using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetPromotionApplyQueryResponse.
    /// </summary>
    public class AlipayFinancialnetPromotionApplyQueryResponse : AopResponse
    {
        /// <summary>
        /// 网商申请单号
        /// </summary>
        [XmlElement("loan_order_no")]
        public string LoanOrderNo { get; set; }

        /// <summary>
        /// 签约订单编号
        /// </summary>
        [XmlElement("sign_order_no")]
        public string SignOrderNo { get; set; }

        /// <summary>
        /// 蚂蚁traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
