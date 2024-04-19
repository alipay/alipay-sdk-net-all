using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneContentCommunitySegmentRealtimeSaveResponse.
    /// </summary>
    public class AntfortuneContentCommunitySegmentRealtimeSaveResponse : AopResponse
    {
        /// <summary>
        /// 返回结果示例
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// trace信息，方便排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
