using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyncData Data Structure.
    /// </summary>
    [Serializable]
    public class SyncData : AopObject
    {
        /// <summary>
        /// 字段field
        /// </summary>
        [XmlElement("field")]
        public string Field { get; set; }

        /// <summary>
        /// 字段值，默认转成字符串类型
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
