using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerZmcardIdentityQueryResponse.
    /// </summary>
    public class ZhimaCustomerZmcardIdentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 通过该URL可以跳转到芝麻证身份账户详情页面，有效期10分钟。如果是主态访问，已授权的情况下才会返回该链接；如果是客态访问，持证人已授权且身份验证通过的情况下才会返回该链接
        /// </summary>
        [XmlElement("skip_url")]
        public string SkipUrl { get; set; }

        /// <summary>
        /// true：验证通过，false：验证未通过
        /// </summary>
        [XmlElement("verified")]
        public bool Verified { get; set; }
    }
}
