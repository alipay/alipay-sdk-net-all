using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VcpUniqueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VcpUniqueInfo : AopObject
    {
        /// <summary>
        /// 根据unique_type决定入参类型
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 唯一ID类型
        /// </summary>
        [XmlElement("unique_type")]
        public string UniqueType { get; set; }
    }
}
