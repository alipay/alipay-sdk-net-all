using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AvatarVO Data Structure.
    /// </summary>
    [Serializable]
    public class AvatarVO : AopObject
    {
        /// <summary>
        /// 虚拟形象的模型信息
        /// </summary>
        [XmlElement("avatar_gltf_info")]
        public string AvatarGltfInfo { get; set; }

        /// <summary>
        /// 标识数字形象的id
        /// </summary>
        [XmlElement("avatar_id")]
        public string AvatarId { get; set; }

        /// <summary>
        /// 当前虚拟形象的名称
        /// </summary>
        [XmlElement("avatar_name")]
        public string AvatarName { get; set; }

        /// <summary>
        /// 虚拟形象的类型信息
        /// </summary>
        [XmlElement("avatar_type")]
        public string AvatarType { get; set; }

        /// <summary>
        /// 说明形象是否为默认形象
        /// </summary>
        [XmlElement("default_avatar")]
        public bool DefaultAvatar { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 是否为用户真实性别
        /// </summary>
        [XmlElement("real_gender")]
        public bool RealGender { get; set; }
    }
}
