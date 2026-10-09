using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatUsage Data Structure.
    /// </summary>
    [Serializable]
    public class ChatUsage : AopObject
    {
        /// <summary>
        /// input 部分消耗的 Token 总数。
        /// </summary>
        [XmlElement("input_count")]
        public long InputCount { get; set; }

        /// <summary>
        /// output 部分消耗的 Token 总数。
        /// </summary>
        [XmlElement("output_count")]
        public long OutputCount { get; set; }

        /// <summary>
        /// 本次对话消耗的 Token 总数，包括 input 和 output 部分的消耗。
        /// </summary>
        [XmlElement("token_count")]
        public long TokenCount { get; set; }
    }
}
