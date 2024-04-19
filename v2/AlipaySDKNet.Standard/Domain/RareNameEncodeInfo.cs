using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RareNameEncodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RareNameEncodeInfo : AopObject
    {
        /// <summary>
        /// 枚举值: PUA,UNICODE
        /// </summary>
        [XmlElement("encode")]
        public string Encode { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
