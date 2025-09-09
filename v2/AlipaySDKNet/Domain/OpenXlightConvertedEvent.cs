using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenXlightConvertedEvent Data Structure.
    /// </summary>
    [Serializable]
    public class OpenXlightConvertedEvent : AopObject
    {
        /// <summary>
        /// 转化事件英文值
        /// </summary>
        [XmlElement("event")]
        public string Event { get; set; }

        /// <summary>
        /// 转化事件对应中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
