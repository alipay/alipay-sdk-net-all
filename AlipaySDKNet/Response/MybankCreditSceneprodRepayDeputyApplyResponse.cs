using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodRepayDeputyApplyResponse.
    /// </summary>
    public class MybankCreditSceneprodRepayDeputyApplyResponse : AopResponse
    {
        /// <summary>
        /// 网商分配的申请单号
        /// </summary>
        [XmlElement("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 代客还款账单详情
        /// </summary>
        [XmlArray("bill_list")]
        [XmlArrayItem("scene_prod_deputy_payment_bill_query")]
        public List<SceneProdDeputyPaymentBillQuery> BillList { get; set; }

        /// <summary>
        /// 网商分配的支用号
        /// </summary>
        [XmlElement("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 网商traceId，便于查询日志内容
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
