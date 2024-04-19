using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NameOuterIdPair Data Structure.
    /// </summary>
    [Serializable]
    public class NameOuterIdPair : AopObject
    {
        /// <summary>
        /// 属性或者规格的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部ID
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }
    }
}
