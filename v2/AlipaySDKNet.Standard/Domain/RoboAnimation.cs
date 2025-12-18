using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboAnimation Data Structure.
    /// </summary>
    [Serializable]
    public class RoboAnimation : AopObject
    {
        /// <summary>
        /// 动画id
        /// </summary>
        [XmlElement("animation_id")]
        public string AnimationId { get; set; }

        /// <summary>
        /// 动画链接
        /// </summary>
        [XmlElement("animation_url")]
        public string AnimationUrl { get; set; }

        /// <summary>
        /// 示例图
        /// </summary>
        [XmlElement("example_image_url")]
        public string ExampleImageUrl { get; set; }

        /// <summary>
        /// 动画排序字段
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
