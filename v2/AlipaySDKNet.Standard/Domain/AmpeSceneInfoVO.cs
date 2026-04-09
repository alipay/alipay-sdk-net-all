using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeSceneInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeSceneInfoVO : AopObject
    {
        /// <summary>
        /// 场景id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 场景的中文描述
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
