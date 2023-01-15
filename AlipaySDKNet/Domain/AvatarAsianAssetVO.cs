using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AvatarAsianAssetVO Data Structure.
    /// </summary>
    [Serializable]
    public class AvatarAsianAssetVO : AopObject
    {
        /// <summary>
        /// 额外参数
        /// </summary>
        [XmlElement("ext_model_info")]
        public string ExtModelInfo { get; set; }

        /// <summary>
        /// 获取配置
        /// </summary>
        [XmlElement("give_config")]
        public GiveConfigVO GiveConfig { get; set; }

        /// <summary>
        /// 获取方式
        /// </summary>
        [XmlElement("give_type")]
        public string GiveType { get; set; }

        /// <summary>
        /// gltf模型
        /// </summary>
        [XmlElement("gltf_url")]
        public string GltfUrl { get; set; }

        /// <summary>
        /// 获取/创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 资产初始动作
        /// </summary>
        [XmlElement("init_behavior")]
        public string InitBehavior { get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 预览图
        /// </summary>
        [XmlElement("preview")]
        public string Preview { get; set; }

        /// <summary>
        /// 是否拥有
        /// </summary>
        [XmlElement("reward_status")]
        public string RewardStatus { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 资产类型名称
        /// </summary>
        [XmlElement("type_name")]
        public string TypeName { get; set; }
    }
}
