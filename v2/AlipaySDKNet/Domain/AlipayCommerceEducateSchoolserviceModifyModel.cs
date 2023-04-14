using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSchoolserviceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSchoolserviceModifyModel : AopObject
    {
        /// <summary>
        /// 服务关联的内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务外部ID，要求唯一
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_app_id")]
        public string ServiceAppId { get; set; }

        /// <summary>
        /// 支付宝返回的服务唯一ID，修改时需要传入
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 服务目标url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
