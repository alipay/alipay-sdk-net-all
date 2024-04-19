using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiBundleAppServiceResult Data Structure.
    /// </summary>
    [Serializable]
    public class MultiBundleAppServiceResult : AopObject
    {
        /// <summary>
        /// 多端服务客户端标识
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [XmlElement("carrier_url")]
        public string CarrierUrl { get; set; }

        /// <summary>
        /// 是否拥有当前端的链接
        /// </summary>
        [XmlElement("has_bundle_url")]
        public bool HasBundleUrl { get; set; }

        /// <summary>
        /// 服务logo
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 小程序子服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 叮咚买药
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 子服务简要介绍
        /// </summary>
        [XmlElement("simple_desc")]
        public string SimpleDesc { get; set; }
    }
}
