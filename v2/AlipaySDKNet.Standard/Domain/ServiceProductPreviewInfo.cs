using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceProductPreviewInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceProductPreviewInfo : AopObject
    {
        /// <summary>
        /// 服务的拓展信息id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 预览图片地址
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 预览图片名称
        /// </summary>
        [XmlElement("preview_url_name")]
        public string PreviewUrlName { get; set; }

        /// <summary>
        /// 服务产品id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
