using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBqLoginCertifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalBqLoginCertifyResponse : AopResponse
    {
        /// <summary>
        /// 用于返回用户信息（姓名、证件号码、证件类型、手机号）
        /// </summary>
        [XmlElement("user_auth_detail")]
        public BianQueUserAuthDetail UserAuthDetail { get; set; }
    }
}
