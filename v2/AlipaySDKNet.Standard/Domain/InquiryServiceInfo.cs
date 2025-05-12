using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InquiryServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InquiryServiceInfo : AopObject
    {
        /// <summary>
        /// 服务所在平台
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 币种符号 ?
        /// </summary>
        [XmlElement("pre_unit")]
        public string PreUnit { get; set; }

        /// <summary>
        /// 服务价格 元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 服务模式： IMAGE_INQUIRY ：图文问诊 PHONE_INQUIRY ：电话问诊
        /// </summary>
        [XmlElement("service_mode")]
        public string ServiceMode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务链接
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
