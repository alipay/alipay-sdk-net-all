using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskDetectionMap Data Structure.
    /// </summary>
    [Serializable]
    public class RiskDetectionMap : AopObject
    {
        /// <summary>
        /// 参数的名字
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
