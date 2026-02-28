using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderNpassporterVerifyconfigCreateResponse.
    /// </summary>
    public class AlipayOfflineProviderNpassporterVerifyconfigCreateResponse : AopResponse
    {
        /// <summary>
        /// 核验配置Id
        /// </summary>
        [XmlElement("verify_config_id")]
        public string VerifyConfigId { get; set; }
    }
}
