using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DstDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DstDetail : AopObject
    {
        /// <summary>
        /// 多轮答案内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 意图信息
        /// </summary>
        [XmlElement("intent")]
        public string Intent { get; set; }
    }
}
