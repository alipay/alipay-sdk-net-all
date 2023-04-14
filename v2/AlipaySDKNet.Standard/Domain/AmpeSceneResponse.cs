using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmpeSceneResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AmpeSceneResponse : AopObject
    {
        /// <summary>
        /// 场景id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
