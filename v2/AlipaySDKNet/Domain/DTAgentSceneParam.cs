using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DTAgentSceneParam Data Structure.
    /// </summary>
    [Serializable]
    public class DTAgentSceneParam : AopObject
    {
        /// <summary>
        /// 场景业务参数
        /// </summary>
        [XmlElement("scene_ext_info")]
        public DTAgentExtInfo SceneExtInfo { get; set; }

        /// <summary>
        /// 可选值，为当前页面产品名称，用于算法workflow提升精度
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 场景用户id，标识同一个用户提问的问题，可用于提升回答准确度
        /// </summary>
        [XmlElement("scene_user_id")]
        public string SceneUserId { get; set; }
    }
}
