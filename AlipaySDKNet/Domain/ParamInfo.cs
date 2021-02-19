using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParamInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParamInfo : AopObject
    {
        /// <summary>
        /// 参数名
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
