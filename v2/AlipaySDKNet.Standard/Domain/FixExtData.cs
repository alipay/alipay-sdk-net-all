using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FixExtData Data Structure.
    /// </summary>
    [Serializable]
    public class FixExtData : AopObject
    {
        /// <summary>
        /// 生态协同平台中，扩展信息的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 生态协同平台中，扩展信息的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
