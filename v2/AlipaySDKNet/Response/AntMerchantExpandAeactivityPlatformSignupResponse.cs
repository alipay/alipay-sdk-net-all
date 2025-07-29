using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAeactivityPlatformSignupResponse.
    /// </summary>
    public class AntMerchantExpandAeactivityPlatformSignupResponse : AopResponse
    {
        /// <summary>
        /// 报名结果
        /// </summary>
        [XmlElement("signup_result")]
        public string SignupResult { get; set; }
    }
}
