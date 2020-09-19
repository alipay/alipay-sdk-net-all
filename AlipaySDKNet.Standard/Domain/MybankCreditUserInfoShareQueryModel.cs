using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditUserInfoShareQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditUserInfoShareQueryModel : AopObject
    {
        /// <summary>
        /// 访问令牌。通过该令牌调用需要授权类接口. mybank.credit.user.system.oauth.query接口返回
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }
    }
}
