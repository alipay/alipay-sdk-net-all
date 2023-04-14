using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenbizmockMapExt Data Structure.
    /// </summary>
    [Serializable]
    public class OpenbizmockMapExt : AopObject
    {
        /// <summary>
        /// 参数的key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数的value
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
