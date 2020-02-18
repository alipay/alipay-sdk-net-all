using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiContentContentinfoCreateResponse.
    /// </summary>
    public class KoubeiContentContentinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 内容id,由内容创建成功后返回。存在返回结果实体类中的data字段内。
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// traceId,全链路Id.
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
