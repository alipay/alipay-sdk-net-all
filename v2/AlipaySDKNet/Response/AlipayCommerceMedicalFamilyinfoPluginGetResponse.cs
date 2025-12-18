using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalFamilyinfoPluginGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalFamilyinfoPluginGetResponse : AopResponse
    {
        /// <summary>
        /// 访问令牌，与url中accessToken的值一致
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 医疗健康我的家人信息插件地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
