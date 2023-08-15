using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvCreateandpayResponse.
    /// </summary>
    public class AlipayCloudCloudbaseEnvCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 全局环境变量ID
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }
    }
}
