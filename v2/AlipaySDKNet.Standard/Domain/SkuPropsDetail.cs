using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuPropsDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SkuPropsDetail : AopObject
    {
        /// <summary>
        /// 属性对于等图片
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 属性值名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 属性id
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
