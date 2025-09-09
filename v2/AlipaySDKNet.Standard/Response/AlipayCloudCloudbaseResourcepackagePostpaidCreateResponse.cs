using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackagePostpaidCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackagePostpaidCreateResponse : AopResponse
    {
        /// <summary>
        /// 外部环境id
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }
    }
}
