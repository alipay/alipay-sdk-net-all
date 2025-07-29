using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskPolicyCaptchaCheckResponse.
    /// </summary>
    public class AlipaySecurityRiskPolicyCaptchaCheckResponse : AopResponse
    {
        /// <summary>
        /// 处置动作
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 对于业务夹带链路的咨询阶段，二次验证配置，业务前端需要消费该配置，调用captcha sdk的js api唤起验证码页面
        /// </summary>
        [XmlElement("captcha_config")]
        public string CaptchaConfig { get; set; }

        /// <summary>
        /// traceid，用于问题排查
        /// </summary>
        [XmlElement("trace")]
        public string Trace { get; set; }
    }
}
