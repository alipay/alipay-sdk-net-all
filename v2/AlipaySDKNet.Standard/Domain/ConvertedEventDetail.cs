using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConvertedEventDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ConvertedEventDetail : AopObject
    {
        /// <summary>
        /// 转化
        /// </summary>
        [XmlElement("converted_event")]
        public string ConvertedEvent { get; set; }

        /// <summary>
        /// 转化名称
        /// </summary>
        [XmlElement("converted_event_name")]
        public string ConvertedEventName { get; set; }
    }
}
