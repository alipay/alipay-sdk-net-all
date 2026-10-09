using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetBomAttribute Data Structure.
    /// </summary>
    [Serializable]
    public class AssetBomAttribute : AopObject
    {
        /// <summary>
        /// 属性编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
