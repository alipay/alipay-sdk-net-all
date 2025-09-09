using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResponseMsg Data Structure.
    /// </summary>
    [Serializable]
    public class ResponseMsg : AopObject
    {
        /// <summary>
        /// 响应结果的具体内容，结构由 type 控制
        /// </summary>
        [XmlElement("content")]
        public ResponseContent Content { get; set; }

        /// <summary>
        /// 响应结果的具体类型，控制 content 字段的具体结构。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
