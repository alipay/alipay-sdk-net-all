using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdPublicTabInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AdPublicTabInfo : AopObject
    {
        /// <summary>
        /// 生活号id
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 图标链接
        /// </summary>
        [XmlElement("public_logo_url")]
        public string PublicLogoUrl { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("public_name")]
        public string PublicName { get; set; }
    }
}
