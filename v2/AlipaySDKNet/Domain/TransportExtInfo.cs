using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransportExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransportExtInfo : AopObject
    {
        /// <summary>
        /// 扩展信息里的具体字段描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 补充信息的展示，例如城市名称
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
