using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardExtInfoDTO : AopObject
    {
        /// <summary>
        /// mapkey值
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
