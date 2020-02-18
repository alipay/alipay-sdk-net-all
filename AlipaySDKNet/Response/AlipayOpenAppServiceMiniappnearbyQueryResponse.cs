using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbyQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceMiniappnearbyQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务载体编码
        /// </summary>
        [XmlElement("carrier_code")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// 载体url
        /// </summary>
        [XmlElement("carrier_url")]
        public string CarrierUrl { get; set; }

        /// <summary>
        /// 服务详述
        /// </summary>
        [XmlElement("detail_desc")]
        public string DetailDesc { get; set; }

        /// <summary>
        /// 前台类目id
        /// </summary>
        [XmlElement("forward_catalog_id")]
        public string ForwardCatalogId { get; set; }

        /// <summary>
        /// 服务关键词
        /// </summary>
        [XmlElement("key_word_list")]
        public string KeyWordList { get; set; }

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

        /// <summary>
        /// 服务简述
        /// </summary>
        [XmlElement("simple_desc")]
        public string SimpleDesc { get; set; }
    }
}
