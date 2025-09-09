using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HistoryQueryAndAnswer Data Structure.
    /// </summary>
    [Serializable]
    public class HistoryQueryAndAnswer : AopObject
    {
        /// <summary>
        /// 历史回答
        /// </summary>
        [XmlElement("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// 历史提问
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }
    }
}
