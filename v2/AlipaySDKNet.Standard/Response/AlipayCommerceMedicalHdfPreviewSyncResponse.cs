using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfPreviewSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfPreviewSyncResponse : AopResponse
    {
        /// <summary>
        /// 日志链路id
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }
    }
}
