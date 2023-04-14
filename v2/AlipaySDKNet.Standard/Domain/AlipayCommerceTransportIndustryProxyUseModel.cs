using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIndustryProxyUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIndustryProxyUseModel : AopObject
    {
        /// <summary>
        /// 描述当前行业代理请求的请求事件
        /// </summary>
        [XmlElement("industry_event")]
        public string IndustryEvent { get; set; }

        /// <summary>
        /// 行业代理请求的业务请求内容，根据行业场景、行业事件的变化而不同
        /// </summary>
        [XmlElement("industry_request")]
        public string IndustryRequest { get; set; }

        /// <summary>
        /// 描述当前行业代理请求的请求场景
        /// </summary>
        [XmlElement("industry_scene")]
        public string IndustryScene { get; set; }

        /// <summary>
        /// 网关open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支持商户接入此业务的系统服务商id
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }

        /// <summary>
        /// 商户特殊用户ID|蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
