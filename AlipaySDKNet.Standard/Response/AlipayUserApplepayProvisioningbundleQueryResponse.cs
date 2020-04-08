using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleQueryResponse.
    /// </summary>
    public class AlipayUserApplepayProvisioningbundleQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡状态
        /// </summary>
        [XmlElement("pass_state")]
        public string PassState { get; set; }

        /// <summary>
        /// 卡模型
        /// </summary>
        [XmlElement("provisioning_bundle")]
        public OpenApiProvisioningBundle ProvisioningBundle { get; set; }

        /// <summary>
        /// 响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
