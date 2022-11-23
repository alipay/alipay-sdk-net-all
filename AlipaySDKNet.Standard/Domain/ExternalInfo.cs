using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalInfo : AopObject
    {
        /// <summary>
        /// 渠道id号
        /// </summary>
        [XmlElement("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 扩展信息map的格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部id号
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 外部信息的名称
        /// </summary>
        [XmlElement("external_name")]
        public string ExternalName { get; set; }

        /// <summary>
        /// 记录id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
