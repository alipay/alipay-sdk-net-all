using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LubContactWayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LubContactWayInfo : AopObject
    {
        /// <summary>
        /// 联系方式类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 联系方式值（电话号码）
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
