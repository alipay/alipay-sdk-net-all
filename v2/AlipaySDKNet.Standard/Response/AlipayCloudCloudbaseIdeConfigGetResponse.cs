using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseIdeConfigGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseIdeConfigGetResponse : AopResponse
    {
        /// <summary>
        /// accessKey
        /// </summary>
        [XmlElement("access_key")]
        public string AccessKey { get; set; }

        /// <summary>
        /// 网关配置
        /// </summary>
        [XmlArray("gateway_configs")]
        [XmlArrayItem("gateway_config")]
        public List<GatewayConfig> GatewayConfigs { get; set; }

        /// <summary>
        /// secretKey
        /// </summary>
        [XmlElement("secret_key")]
        public string SecretKey { get; set; }
    }
}
