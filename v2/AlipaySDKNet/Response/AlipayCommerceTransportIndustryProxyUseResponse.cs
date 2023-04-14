using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryProxyUseResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryProxyUseResponse : AopResponse
    {
        /// <summary>
        /// 行业代理响应，根据行业场景、行业事件的变化而不同
        /// </summary>
        [XmlElement("industry_response")]
        public string IndustryResponse { get; set; }
    }
}
