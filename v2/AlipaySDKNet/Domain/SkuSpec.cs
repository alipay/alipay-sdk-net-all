using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuSpec Data Structure.
    /// </summary>
    [Serializable]
    public class SkuSpec : AopObject
    {
        /// <summary>
        /// 规格名
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 规格值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
