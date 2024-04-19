using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiContentContentcountSetResponse.
    /// </summary>
    public class KoubeiContentContentcountSetResponse : AopResponse
    {
        /// <summary>
        /// 口碑内容的唯一id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 全链路唯一id,由服务系统提供
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
