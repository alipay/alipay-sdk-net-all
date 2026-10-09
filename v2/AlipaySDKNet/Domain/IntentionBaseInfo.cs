using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IntentionBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntentionBaseInfo : AopObject
    {
        /// <summary>
        /// 意图信息中的动作
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 意图信息中的行业
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 意图信息中的场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
