using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtraInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtraInfo : AopObject
    {
        /// <summary>
        /// 扩展信息key
        /// </summary>
        [XmlElement("extra_info_key")]
        public string ExtraInfoKey { get; set; }

        /// <summary>
        /// 扩展信息value
        /// </summary>
        [XmlElement("extra_info_value")]
        public string ExtraInfoValue { get; set; }
    }
}
