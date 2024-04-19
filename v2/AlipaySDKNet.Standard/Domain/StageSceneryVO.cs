using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StageSceneryVO Data Structure.
    /// </summary>
    [Serializable]
    public class StageSceneryVO : AopObject
    {
        /// <summary>
        /// 布景预览图信息
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 布景id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 布景模型的url信息
        /// </summary>
        [XmlElement("scenery_gltf_url")]
        public string SceneryGltfUrl { get; set; }

        /// <summary>
        /// 布景名称信息
        /// </summary>
        [XmlElement("scenery_name")]
        public string SceneryName { get; set; }
    }
}
