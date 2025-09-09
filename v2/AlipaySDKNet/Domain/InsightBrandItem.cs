using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsightBrandItem Data Structure.
    /// </summary>
    [Serializable]
    public class InsightBrandItem : AopObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 品牌数量
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
