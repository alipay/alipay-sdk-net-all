using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJobagentSessionInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJobagentSessionInitializeModel : AopObject
    {
        /// <summary>
        /// 外部会话id
        /// </summary>
        [XmlElement("out_session_id")]
        public string OutSessionId { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
