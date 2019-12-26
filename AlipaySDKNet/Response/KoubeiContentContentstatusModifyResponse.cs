using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiContentContentstatusModifyResponse.
    /// </summary>
    public class KoubeiContentContentstatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 口碑内容的唯一id
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("string")]
        public List<string> Data { get; set; }

        /// <summary>
        /// 全链路唯一id,由服务系统提供
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
