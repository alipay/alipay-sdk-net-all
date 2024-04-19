using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockVerifyReportSyncResponse.
    /// </summary>
    public class AntfortuneStockVerifyReportSyncResponse : AopResponse
    {
        /// <summary>
        /// 域内 trace-id，用来联系蚂蚁排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
