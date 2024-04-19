using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchAgentframeworkWarrenqGetResponse.
    /// </summary>
    public class AntfortuneFinresearchAgentframeworkWarrenqGetResponse : AopResponse
    {
        /// <summary>
        /// 最终答案
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 执行的状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 执行的中间过程
        /// </summary>
        [XmlElement("steps")]
        public string Steps { get; set; }
    }
}
