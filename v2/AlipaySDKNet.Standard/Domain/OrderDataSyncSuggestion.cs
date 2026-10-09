using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDataSyncSuggestion Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDataSyncSuggestion : AopObject
    {
        /// <summary>
        /// 同步建议内容
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 同步建议类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
