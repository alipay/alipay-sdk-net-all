using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgContent Data Structure.
    /// </summary>
    [Serializable]
    public class MsgContent : AopObject
    {
        /// <summary>
        /// 内容产生的时间
        /// </summary>
        [XmlElement("content_timestamp")]
        public string ContentTimestamp { get; set; }

        /// <summary>
        /// 内容类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }
    }
}
