using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoActivityAttrOptionVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoActivityAttrOptionVO : AopObject
    {
        /// <summary>
        /// 描述可选项的名称
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 可选项的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
