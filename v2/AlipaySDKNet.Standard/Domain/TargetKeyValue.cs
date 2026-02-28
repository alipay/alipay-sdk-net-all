using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TargetKeyValue Data Structure.
    /// </summary>
    [Serializable]
    public class TargetKeyValue : AopObject
    {
        /// <summary>
        /// 目标点属性key，如图层类型编号属性key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 目标点属性value，如图层类型编号属性value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
