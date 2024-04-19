using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SceneDTO : AopObject
    {
        /// <summary>
        /// 场景编码+唯一+场景列表查询
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景名称+不唯一+场景列表查询
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
