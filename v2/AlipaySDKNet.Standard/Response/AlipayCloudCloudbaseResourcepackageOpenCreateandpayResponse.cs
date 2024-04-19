using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageOpenCreateandpayResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageOpenCreateandpayResponse : AopResponse
    {
        /// <summary>
        /// 外部环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }
    }
}
