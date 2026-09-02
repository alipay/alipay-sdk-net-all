using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WhiteTypeItem Data Structure.
    /// </summary>
    [Serializable]
    public class WhiteTypeItem : AopObject
    {
        /// <summary>
        /// 白名单类型名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 白名单类型编码
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
