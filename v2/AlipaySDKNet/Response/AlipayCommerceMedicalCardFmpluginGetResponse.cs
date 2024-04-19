using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardFmpluginGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardFmpluginGetResponse : AopResponse
    {
        /// <summary>
        /// 访问令牌，与url中accessToken的值一致
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 亲情账户绑定关系插件地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
