using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskPolicyCaptchaCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskPolicyCaptchaCheckModel : AopObject
    {
        /// <summary>
        /// 用来串联一次业务请求下，多个验证码id的串联流水号
        /// </summary>
        [XmlElement("captcha_bizno")]
        public string CaptchaBizno { get; set; }

        /// <summary>
        /// 业务场景id
        /// </summary>
        [XmlElement("captcha_id")]
        public string CaptchaId { get; set; }

        /// <summary>
        /// 默认值为空，代表验证码token校验请求，如果是咨询阶段传CONSULT
        /// </summary>
        [XmlElement("captcha_scene")]
        public string CaptchaScene { get; set; }

        /// <summary>
        /// 验证码验证通过的凭证，json字符串，通过captchasdk获取之后，透传给业务服务端，业务服务端再传给验证码服务端
        /// </summary>
        [XmlElement("captcha_token")]
        public string CaptchaToken { get; set; }

        /// <summary>
        /// 业务前端通过调用验证码sdk提供的getRiskData接口获取的咨询数据，格式是一个json字符串，需要透传到业务服务端，业务服务端再透传给行为验证服务端；如果是token校验请求，这个字段为空
        /// </summary>
        [XmlElement("consult_data")]
        public string ConsultData { get; set; }

        /// <summary>
        /// 额外的防控参数，例如手机号、设备号等信息，map<string,object>经过json encode之后的json字符串
        /// </summary>
        [XmlElement("extra_data")]
        public string ExtraData { get; set; }
    }
}
