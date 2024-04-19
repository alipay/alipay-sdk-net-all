using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppinfoQueryResponse.
    /// </summary>
    public class AlipayOpenAppinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 应用openid配置
        /// </summary>
        [XmlElement("open_id_config")]
        public string OpenIdConfig { get; set; }
    }
}
