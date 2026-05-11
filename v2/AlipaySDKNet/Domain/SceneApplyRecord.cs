using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneApplyRecord Data Structure.
    /// </summary>
    [Serializable]
    public class SceneApplyRecord : AopObject
    {
        /// <summary>
        /// 生效时间 格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 场景名称信息
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 场景状态
        /// </summary>
        [XmlElement("scene_status")]
        public string SceneStatus { get; set; }
    }
}
