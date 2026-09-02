using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LubCopyContactWayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LubCopyContactWayInfo : AopObject
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
