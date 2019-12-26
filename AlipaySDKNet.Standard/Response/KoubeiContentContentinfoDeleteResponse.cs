using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiContentContentinfoDeleteResponse.
    /// </summary>
    public class KoubeiContentContentinfoDeleteResponse : AopResponse
    {
        /// <summary>
        /// 口碑内容的唯一id
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 全链路Id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
