using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEcodeOpenQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalEcodeOpenQueryResponse : AopResponse
    {
        /// <summary>
        /// 脱敏用户支付宝登录名
        /// </summary>
        [XmlElement("login_name")]
        public string LoginName { get; set; }

        /// <summary>
        /// 用户是否开通一码付
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }
    }
}
