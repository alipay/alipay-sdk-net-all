using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourceRelatedItem Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceRelatedItem : AopObject
    {
        /// <summary>
        /// 请求原始URL
        /// </summary>
        [XmlElement("resource_ask_url")]
        public string ResourceAskUrl { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("resource_type")]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源项地址
        /// </summary>
        [XmlElement("resource_url")]
        public string ResourceUrl { get; set; }
    }
}
