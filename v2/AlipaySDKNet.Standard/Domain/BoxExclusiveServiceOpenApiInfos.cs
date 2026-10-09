using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxExclusiveServiceOpenApiInfos Data Structure.
    /// </summary>
    [Serializable]
    public class BoxExclusiveServiceOpenApiInfos : AopObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 不可用类目id
        /// </summary>
        [XmlElement("catalog_id")]
        public string CatalogId { get; set; }

        /// <summary>
        /// 不可用类目名称
        /// </summary>
        [XmlElement("catalog_name")]
        public string CatalogName { get; set; }

        /// <summary>
        /// 服务规格编码（SP_MINI_APP/SP_PUBLIC_APP，小程序/生活号）
        /// </summary>
        [XmlElement("sepc_code")]
        public string SepcCode { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务logo
        /// </summary>
        [XmlElement("service_logo")]
        public string ServiceLogo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
