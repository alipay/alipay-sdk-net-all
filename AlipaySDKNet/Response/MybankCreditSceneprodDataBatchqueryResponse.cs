using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSceneprodDataBatchqueryResponse.
    /// </summary>
    public class MybankCreditSceneprodDataBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 订单数据查询的返回值。通过列表方式批量返回机构的订单查询数据。通过系统控制返回的数据中不包含客户的敏感信息。
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("scene_prod_data_query_result_detail")]
        public List<SceneProdDataQueryResultDetail> ResultData { get; set; }

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
