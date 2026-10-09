using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AvatarAnimationVO Data Structure.
    /// </summary>
    [Serializable]
    public class AvatarAnimationVO : AopObject
    {
        /// <summary>
        /// 对于动画的具体描述
        /// </summary>
        [XmlElement("animation_desc")]
        public string AnimationDesc { get; set; }

        /// <summary>
        /// 动画的gltf模型url
        /// </summary>
        [XmlElement("animation_gltf_url")]
        public string AnimationGltfUrl { get; set; }

        /// <summary>
        /// 动画的形容名称
        /// </summary>
        [XmlElement("animation_name")]
        public string AnimationName { get; set; }

        /// <summary>
        /// 动画类型
        /// </summary>
        [XmlElement("animation_type")]
        public string AnimationType { get; set; }

        /// <summary>
        /// 动画适用的虚拟化身组
        /// </summary>
        [XmlArray("avatar_types")]
        [XmlArrayItem("string")]
        public List<string> AvatarTypes { get; set; }

        /// <summary>
        /// 动画的预览图
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 动画对应的标识id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
