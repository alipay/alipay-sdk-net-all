using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLiveAnchorResourceAuditModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLiveAnchorResourceAuditModel : AopObject
    {
        /// <summary>
        /// 鉴权token
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 玩法名称
        /// </summary>
        [XmlElement("interactive_name")]
        public string InteractiveName { get; set; }

        /// <summary>
        /// 主播号ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("resource_list")]
        [XmlArrayItem("string")]
        public List<string> ResourceList { get; set; }

        /// <summary>
        /// TEXT：文本 IMAGE：图片 VIDEO：视频
        /// </summary>
        [XmlElement("resource_type")]
        public string ResourceType { get; set; }
    }
}
