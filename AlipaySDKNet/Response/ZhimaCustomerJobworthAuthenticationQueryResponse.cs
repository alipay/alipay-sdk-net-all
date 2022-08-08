using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthAuthenticationQueryResponse.
    /// </summary>
    public class ZhimaCustomerJobworthAuthenticationQueryResponse : AopResponse
    {
        /// <summary>
        /// T代表可信，F代表不可信，U代表未知需要等待结果
        /// </summary>
        [XmlElement("identity_result")]
        public string IdentityResult { get; set; }

        /// <summary>
        /// 身份认证查询结果页面，有芝麻提供，商家可以继承到自己app或者小程序内，用户点击后即可看到认证结果
        /// </summary>
        [XmlElement("identity_result_skip_url")]
        public string IdentityResultSkipUrl { get; set; }
    }
}
