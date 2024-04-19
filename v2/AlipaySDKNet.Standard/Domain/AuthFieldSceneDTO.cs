using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthFieldSceneDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AuthFieldSceneDTO : AopObject
    {
        /// <summary>
        /// 场景CODE
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景code描述
        /// </summary>
        [XmlElement("scene_desc")]
        public string SceneDesc { get; set; }
    }
}
