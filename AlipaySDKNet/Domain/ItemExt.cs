using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemExt Data Structure.
    /// </summary>
    [Serializable]
    public class ItemExt : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息值
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }
    }
}
