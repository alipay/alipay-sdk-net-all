using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneContentCommunityOpenSecuaiQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunityOpenSecuaiQueryResponse : AopResponse
    {
        /// <summary>
        /// 存储json序列化后的业务结果
        /// </summary>
        [XmlElement("secuai_open_result")]
        public string SecuaiOpenResult { get; set; }

        /// <summary>
        /// trace信息，方便排查问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
