using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentPreconsultResponse.
    /// </summary>
    public class AlipayCommerceMedicalPaymentPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 激活医保电子凭证地址。当result=1时返回。如果请求参数中有callbackURL，那么当用户完成医保电子凭证激活操作后后自动回跳至callbackURL指向的页面
        /// </summary>
        [XmlElement("active_url")]
        public string ActiveUrl { get; set; }

        /// <summary>
        /// 建议的推进策略；商家可参考建议推进业务动作
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }
    }
}
